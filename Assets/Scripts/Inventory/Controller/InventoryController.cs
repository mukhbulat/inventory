
using System.Collections.Generic;
using Inventory.Model;
using Inventory.View;

namespace Inventory.Controller
{
    public class InventoryController
    {
        private List<ItemModel> _inventory = new List<ItemModel>(32);

        // We are assume that there's only 32 cell inventories. But we can make model for inventory to make it
        // any size or whatever. 
        private int _maxCapacity = 32;
        
        public bool AddItemToInventory(ItemView itemView)
        {
            if (itemView == null) return false;
            if (_inventory.Count >= _maxCapacity) return false;
            _inventory.Add(itemView.ItemModel);
            return true;
        }
        
    }
}
