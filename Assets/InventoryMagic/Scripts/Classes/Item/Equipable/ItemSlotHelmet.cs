using UnityEngine;
using System.Collections;

namespace inventoryMagic.Equippable {	
	public class ItemSlotHelmet : IIMEquipmentSlot {
		[SerializeField] private int _slot;
		[SerializeField] private string _name;
		[SerializeField] private Sprite _icon;

		public int Slot { 
			get { 
				return _slot;
			} 
			set {
				_slot = value;
			}
		}

		public string SlotName { 
			get {
				return _name;
			}
			set {
				_name = value;
			} 
		}

		public Sprite Icon {
			get {
				return _icon;
			}
			set {
				_icon = value;
			}
		}
	}
}