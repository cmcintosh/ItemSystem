using UnityEngine;
using System.Collections;

namespace inventoryMagic {
	public interface IIMDestructibleItem {

		int IIMDurability { get; set; }
		int MaxDurability { get; set; }

		void DamageItem(int amount);
		void RepairDurability (int amount);
		void Break ();

	}
}