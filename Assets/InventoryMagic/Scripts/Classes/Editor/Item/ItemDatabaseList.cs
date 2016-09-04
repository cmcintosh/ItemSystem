using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic.ItemEditor {

	public partial class ItemDatabaseEditor : EditorWindow {

		Vector2 _scrollPos = Vector2.zero;
		int _listViewWidth = 125;

		void ItemListView(IIMItemDatabase database) {			
			_scrollPos = GUILayout.BeginScrollView (_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth));

			GUILayout.EndScrollView ();
		}

	}
}