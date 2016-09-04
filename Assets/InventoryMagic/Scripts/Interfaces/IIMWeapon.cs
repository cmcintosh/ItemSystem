using UnityEngine;
using System.Collections;

namespace inventoryMagic {	
	public interface IIMWeapon : IIMItem, IIMEquipableItem, IIMDestructibleItem {
		int MinDamage { get; set; }
		int Attack ();
	}
}