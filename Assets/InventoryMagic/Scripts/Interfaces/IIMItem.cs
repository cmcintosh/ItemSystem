using UnityEngine;
using System.Collections;

namespace inventoryMagic {	
	
	public interface IIMItem {

		void Init( int id, string name );
		int ID { get; }
		string IIMName { get; set; }
		string IIMDescription { get; }
		int IIMValue { get; set; }
		Sprite IIMIcon { get; set; } 
		int IIMWeight { get; set; }
		QualityBase IIMQuality { get; set; }

	}
}