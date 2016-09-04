using UnityEngine;
using System.Collections;

namespace inventoryMagic.Items {	
	[System.Serializable]
	public class Item : IIMItem {

		[SerializeField] int _id;
		[SerializeField] string _name;
		[SerializeField] string _description;
		[SerializeField] int _value;
		[SerializeField] Sprite _icon;
		[SerializeField] int _weight;
		[SerializeField] QualityBase _quality;

		public void Init ( int id, string name){
			_id = id;
			_name = name;
		}

		public int ID {
			get { return _id; }
		}

		public string IIMName {
			get { return _name; }
			set { _name = value; }
		}

		public int IIMValue {
			get { return _value; }
			set { _value = value; }
		}

		public Sprite IIMIcon {
			get { return _icon; }
			set { _icon = value; }
		}

		public int IIMWeight {
			get { return _weight; }
			set { _weight = value; }
		}

		public QualityBase IIMQuality {
			get { return _quality; }
			set { _quality = value; }
		}

		public string IIMDescription {
			get { return _description; }
			set { _description = value; }
		}

	}
}