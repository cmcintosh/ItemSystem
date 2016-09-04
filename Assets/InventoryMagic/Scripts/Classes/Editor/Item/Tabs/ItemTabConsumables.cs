using UnityEditor;
using UnityEngine;
using System.Collections;

namespace inventoryMagic.ItemEditor {
	public partial class ItemDatabaseEditor : EditorWindow {



		void ItemConsumableDisplay () {
			

			GUILayout.BeginScrollView(_scrollEditPos, "Box");

			GUILayout.Label ("Name", _LabelStyle);
			EditorGUILayout.TextField("");
			GUILayout.Label ("Enter the display name for this item.", _DescriptionStyle);

			GUILayout.Label ("Description", _LabelStyle);
			EditorGUILayout.TextArea ("", GUILayout.Height(120));
			GUILayout.Label ("Enter the description or flavor text for this item.", _DescriptionStyle);

			GUILayout.Label ("Value", _LabelStyle);
			EditorGUILayout.IntField(0);
			GUILayout.Label ("Enter the In-Game value of this item.", _DescriptionStyle);

			GUILayout.Label ("Weight", _LabelStyle);
			EditorGUILayout.IntField(0);
			GUILayout.Label ("Enter the weight/burden for this item.", _DescriptionStyle);

			GUILayout.Label ("Quality", _LabelStyle);
			GUILayout.Label ("Select the quality level of this item.", _DescriptionStyle);



			GUILayout.Label ("Effect", _LabelStyle);
			GUILayout.Label ("Select the effect for this item.", _DescriptionStyle);

			GUILayout.Label ("Ticks", _LabelStyle);
			EditorGUILayout.IntField (0);
			GUILayout.Label ("Enter the number of ticks the effect should last.", _DescriptionStyle);


			GUILayout.Button ("Save");
			GUILayout.EndScrollView ();
		}

		void ConsumableListView () {
			_scrollPos = GUILayout.BeginScrollView (_scrollPos, "Box", GUILayout.ExpandHeight (true), GUILayout.Width (_listViewWidth));

			GUILayout.EndScrollView ();
		}
	}
}
