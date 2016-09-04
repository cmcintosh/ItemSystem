using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic.ItemEditor {

	public partial class ItemDatabaseEditor : EditorWindow {

		private int _ActiveTab = 0;

		void TabMenu() {
			
			GUILayout.BeginHorizontal (GUILayout.ExpandWidth (true));
			
			if (GUILayout.Button ("Consumables")) {
				_ActiveTab = 1;
			};
				
			if (GUILayout.Button ("Wearables")) {
				_ActiveTab = 2;
			}
			if (GUILayout.Button ("Weapons")) {
				_ActiveTab = 3;
			}
			if (GUILayout.Button ("Quest Items")) {
				_ActiveTab = 4;
			}
			GUILayout.EndHorizontal ();
			GUILayout.BeginHorizontal (GUILayout.ExpandWidth (true));
			if (GUILayout.Button ("Premium Consumables")) {
				_ActiveTab = 5;
			}
			if (GUILayout.Button ("Premium Wearables")) {
				_ActiveTab = 6;
			}
			if (GUILayout.Button ("Premium Weapons")) {
				_ActiveTab = 7;
			}
			GUILayout.EndHorizontal ();
			GUILayout.BeginHorizontal (GUILayout.ExpandWidth (true));
			if (GUILayout.Button ("About")) {
				_ActiveTab = 0;
			}
			GUILayout.EndHorizontal ();
		}
	}
}