
using System.Collections.Generic;
using Inventory.Model;

namespace Inventory.Controller
{
    public class InventoryController
    {
        private List<Item> _inventory = new List<Item>(32);

        public bool AddItemToInventory(Item item)
        {
            return false;
        }
    }
}
