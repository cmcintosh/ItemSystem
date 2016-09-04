using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic.ItemEditor {

	public partial class ItemDatabaseEditor : EditorWindow {

		void AboutTabDisplay() {
			GUILayout.BeginHorizontal ();
			GUILayout.TextArea ("Welcome to the Wembassy InventoryMagic System.  This Item Editor will allow you to create a wide range of ready to use Items for your projects.");
			GUILayout.EndHorizontal ();
		}
	}
}