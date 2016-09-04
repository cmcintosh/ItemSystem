using UnityEngine;
using UnityEditor;
using System.Collections;

namespace inventoryMagic {
	
	public partial class QualityDatabaseEditor {

		Vector2 _scrollPos;

		private void listQualityItems (){
			_scrollPos = new Vector2 (0, 0);
			EditorGUILayout.BeginScrollView (_scrollPos, GUILayout.ExpandHeight (true) );
			displayItems();
			EditorGUILayout.EndScrollView ();
		}

		private void displayItems() {
			for (int i = 0; i < database.Count; i++) {
				QualityBase row = database.Get (i);
				EditorGUILayout.BeginHorizontal ();
				GUILayout.Button (row.Icon.texture, GUILayout.Width (24), GUILayout.Height (24));

				EditorGUILayout.ColorField(row.Forecolor, GUILayout.Height(24), GUILayout.Width(50));
				EditorGUILayout.TextField(row.Name, GUILayout.Height(24));


				if (GUILayout.Button ("Edit", GUILayout.Width (50), GUILayout.Height (24))) {
					selectedIndex = i;
					selectedQuality = database.Get(i);
					addQuality = false;
					editQuality = true;
				}
				if (GUILayout.Button ("Delete", GUILayout.Width (50), GUILayout.Height (24))) {
					if (EditorUtility.DisplayDialog ("Confirm Delete", "Are you sure you wish to delete this Quality item? This action cannot be undone!", "Yes, I understand")) {
						selectedIndex = i;
						database.Remove (row);
						addQuality = false;
						editQuality = false;
					}
				}

				Repaint ();
				EditorGUILayout.EndHorizontal ();
			}
		}

	}

}