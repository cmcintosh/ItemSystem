using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic.ItemEditor {
	public partial class ItemDatabaseEditor : EditorWindow {

		Vector2 _scrollEditPos = Vector2.zero;

		public void ItemEditor() { 
			_scrollEditPos = GUILayout.BeginScrollView (_scrollEditPos, "Box");



			GUILayout.EndScrollView ();
		}

	}
}