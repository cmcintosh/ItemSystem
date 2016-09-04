using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic.ItemEditor {
	
	public partial class ItemDatabaseEditor : EditorWindow {

		// All current databases I have setup for this asset.
		IIMItemDatabase consumables;
		IIMItemDatabase wearables;
		IIMItemDatabase weapons;
		IIMItemDatabase questItems;
		IIMItemDatabase pConsumables;
		IIMItemDatabase pWearables;
		IIMItemDatabase pWeapons;
		const string FOLDER = "InventoryMagic/Database";

		// 
		GUIStyle _LabelStyle;
		GUIStyle _DescriptionStyle;

		[MenuItem("Assets/Inventory Magic/Databases/Item Editor %#i")]
		public static void ShowEditor() {
			ItemDatabaseEditor window = EditorWindow.GetWindow<ItemDatabaseEditor> ();
			window.minSize = new Vector2 (100, 100 );
			window.titleContent = new UnityEngine.GUIContent("Items");
			window.Show ();
		}

		void OnEnable() { 
			// Get all of our databases.
			// @Todo Change this to make it a Dynamic categorization system.
			consumables = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			consumables = consumables.GetDatabase<IIMItemDatabase> (FOLDER, "ConsumablesDatabase.asset");

			wearables = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			wearables = wearables.GetDatabase<IIMItemDatabase> (FOLDER, "WearablesDatabase.asset");

			weapons = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			weapons = weapons.GetDatabase<IIMItemDatabase> (FOLDER, "WeaponsDatabase.asset");

			questItems = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			questItems = questItems.GetDatabase<IIMItemDatabase> (FOLDER, "QuestItemsDatabase.asset");

			pConsumables = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			pConsumables = pConsumables.GetDatabase<IIMItemDatabase> (FOLDER, "pConsumablesDatabase.asset");

			pWearables = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			pWearables = pWearables.GetDatabase<IIMItemDatabase> (FOLDER, "pWearablesDatabase.asset");

			pWeapons = ScriptableObject.CreateInstance<IIMItemDatabase> ();
			pWeapons = pWeapons.GetDatabase<IIMItemDatabase> (FOLDER, "pWeaponsDatabase.asset");

			// Setup our styles
			_LabelStyle = new GUIStyle();
			_LabelStyle.fontSize = 12;
			_DescriptionStyle = new GUIStyle ();
			_DescriptionStyle.fontSize = 8;
		}

		void OnGUI() { 
			TabMenu (); // Generate the tabs for our item database
			GUILayout.BeginHorizontal();

			switch (_ActiveTab) {
			default:
			case 0:
				  AboutTabDisplay();
				break;
			case 1:
				ConsumableListView ();
				ItemConsumableDisplay();
				break;

			}

			GUILayout.EndHorizontal ();
		}

	}
}