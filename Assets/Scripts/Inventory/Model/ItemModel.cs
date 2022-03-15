using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu()]
    public class ItemModel : ScriptableObject
    {
        public string itemName;
        public string description;
        public int value;
        public int maxStack = 1;
    }
}