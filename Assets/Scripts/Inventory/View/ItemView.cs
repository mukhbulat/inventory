using Inventory.Model;
using UnityEngine;

namespace Inventory.View
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private ItemModel itemModel;
        public ItemModel ItemModel
        {
            get => itemModel;
            private set => itemModel = value;
        }
    }
}