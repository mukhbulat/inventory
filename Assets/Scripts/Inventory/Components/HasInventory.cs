using System;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Components
{
    public class HasInventory : MonoBehaviour
    {
        [SerializeField] private int maxCapacity = 32;

        private List<Item> _inventory;

        private void Awake()
        {
            _inventory = new List<Item>(maxCapacity);
        }

        public bool PickupItem(Item item)
        {
            if (item == null) return false;
            if (_inventory.Count >= maxCapacity) return false;
            _inventory.Add(item);
            return true;
        }

        public bool ThrowItem(Item item)
        {
            if (_inventory.Contains(item))
            {
                _inventory.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}