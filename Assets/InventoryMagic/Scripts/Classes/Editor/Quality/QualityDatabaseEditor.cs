using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic {	
	public partial class QualityDatabaseEditor : EditorWindow {
		[SerializeField]
		IIMQualityDatabase database;
		QualityBase selectedQuality;
		Texture2D selectedQualityTexture;
		int selectedIndex = 0;

		const string FOLDER = "InventoryMagic/Database";
		const string DATABASE_NAME = "QualityDatabase.asset";

		[MenuItem("Assets/Inventory Magic/Databases/Quality Editor %#q")]
		public static void ShowEditor() {
			QualityDatabaseEditor window = EditorWindow.GetWindow<QualityDatabaseEditor> ();
			window.minSize = new Vector2 (500, 400 );
			window.titleContent = new UnityEngine.GUIContent("Quality");
			window.Show ();
		}

		// Once Menu is Enabled.
		void OnEnable() {
			database = ScriptableObject.CreateInstance<IIMQualityDatabase> ();
			database = database.GetDatabase<IIMQualityDatabase> (FOLDER, DATABASE_NAME);
		}

		// Once GUI is rendered.
		void OnGUI () {
			if (database == null) {
				Debug.LogWarning ("Database has not been loaded yet.");
				return;
			}
			addNewQuality ();
			listQualityItems ();
		}

		bool addQuality = false;
		bool editQuality = false;

		void addNewQuality() {
			// name
			if (addQuality || editQuality) {
				EditorGUILayout.BeginHorizontal ();
				// Sprite
				if (selectedQuality.Icon) {
					selectedQualityTexture = selectedQuality.Icon.texture;
				} else {
					selectedQualityTexture = null;
				}

				if (GUILayout.Button (selectedQualityTexture, GUILayout.Width (32), GUILayout.Height (32))) {
					int controllerID = EditorGUIUtility.GetControlID (FocusType.Passive);
					EditorGUIUtility.ShowObjectPicker<Sprite> (null, false, null, controllerID);
				}

				selectedQuality.Name = EditorGUILayout.TextField ("Name:", selectedQuality.Name);
				selectedQuality.Forecolor = EditorGUILayout.ColorField("Item Label Color", selectedQuality.Forecolor);
				EditorGUILayout.EndHorizontal ();

				string cmdName = Event.current.commandName;
				if (cmdName == "ObjectSelectorUpdated") {
					Sprite selectedObject = (Sprite)EditorGUIUtility.GetObjectPickerObject ();
					selectedQuality.Icon = selectedObject;
					Repaint ();
				}

				if (GUILayout.Button ("Save")) {
					if (selectedQuality.Name == null) {
						Debug.LogError ("You must provide a name for your new Quality.");
					} else if (selectedQuality.Icon == null) {
						Debug.LogError ("You must provide a Icon Sprite for your new Quality.");
					} else if (addQuality) {
						database.Add (selectedQuality);
						selectedQuality = new QualityBase ();
						addQuality = false;
					} else {
						database.Replace(selectedIndex, selectedQuality);
						editQuality = false;
					}
				}
			}

			if (GUILayout.Button ("Add")) {
				selectedQuality = new QualityBase ();
				addQuality = true;
			}

			EditorGUILayout.Separator();

		}

	}
}