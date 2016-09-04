using UnityEngine;
using System.Collections;

namespace inventoryMagic {
	
	public interface IIMQuality {
		void Init();
		string Name { get; set; }
		Sprite Icon { get; set; }
		Color Forecolor { get; set; }
	}
}