using UnityEngine;
using System.Collections;

namespace inventoryMagic.Equippable {
	public interface IIMEquipmentSlot {
		int Slot { get; set; }
		string SlotName { get; set; }
		Sprite Icon { get; set; }
	}
}