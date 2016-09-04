using UnityEngine;
using System.Collections;

namespace inventoryMagic {
	public interface IIMStackableItem {
		int MaxStack { get; set; }
		int Stack (int amount);
	}
}