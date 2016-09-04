using UnityEngine;
using System.Collections;

namespace inventoryMagic {
	public interface IIMConsumableItem {
		void IIMEffect();
		int IIMTicks { get; set; }
		bool IIMDestroyOnUse { get; }
	}
}