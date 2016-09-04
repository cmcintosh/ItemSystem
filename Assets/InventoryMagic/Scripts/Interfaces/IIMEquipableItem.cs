using UnityEngine;
using System.Collections;
using inventoryMagic.Equippable;

namespace inventoryMagic {
	public interface IIMEquipableItem {
		IIMEquipmentSlot EquipmentSlot { get; set; }
		bool Equip();
	}
}