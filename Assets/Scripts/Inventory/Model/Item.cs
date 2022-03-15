using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu()]
    public class Item : ScriptableObject
    {
        public string itemName;
        public string description;
        public int value;
        public int maxStack = 1;
    }
}