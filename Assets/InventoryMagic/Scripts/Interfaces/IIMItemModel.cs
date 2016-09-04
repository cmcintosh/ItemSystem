using UnityEngine;
using System.Collections;

namespace inventoryMagic {
	public interface IIMItemModel {
		GameObject Prefab { get; set; }
		GameObject DamagedPrefab { get; set; }
		GameObject DestroyedPrefab { get; set; }
	}
}