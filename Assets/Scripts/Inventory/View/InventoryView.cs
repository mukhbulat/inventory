using System;
using Inventory.Controller;
using Inventory.Model;
using Managers;
using UnityEngine;

namespace Inventory.View
{
    public class InventoryView : MonoBehaviour
    {
        private InventoryController _inventoryController = new InventoryController();

        [SerializeField] private InputManager inputManager;

        private Camera _mainCamera;
        private int _itemMask = 1 << 6;
        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            inputManager.MouseClick += OnMouseClick;
        }

        private void OnDisable()
        {
            inputManager.MouseClick -= OnMouseClick;
        }

        private void OnMouseClick(Vector2 mousePosition)
        {
            Ray ray = _mainCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _itemMask))
            {
                // Checking for null item in controller. AddItem returns if item has been added to inventory.
                if (!_inventoryController.AddItemToInventory(hit.collider.GetComponent<ItemView>()))
                {
                    Debug.Log("Would be great to have UI. Item is not added to inventory.");
                }
                else
                {
                    Destroy(hit.transform);
                }
            }
        }
    }
}