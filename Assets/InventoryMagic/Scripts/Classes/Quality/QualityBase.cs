using UnityEngine;
using System.Collections;

namespace inventoryMagic {	
	[System.Serializable]
	public class QualityBase : IIMQuality {

		[SerializeField] string _name;
		[SerializeField] Sprite _icon;
		[SerializeField] Color _color;

		public void Init()
		{
			_name = "Common";
			_icon = new Sprite ();
		}

		public string Name {
			get { return _name;  }
			set { _name = value; }
		}

		public Sprite Icon {
			get { return _icon;  }
			set { _icon = value; }
		}

		public Color Forecolor {
			get { return _color; }
			set { _color = value; }
		}

	}
}