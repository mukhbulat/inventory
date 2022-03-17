using System;
using Inventory.Components;
using Managers;
using UnityEngine;

namespace Inventory.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private HasInventory hasInventory;
        
        [SerializeField] private InputController inputController;

        private Camera _mainCamera;
        private int _itemLayerMask = 1 << 6;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            inputController.MouseClick += OnMouseClick;
        }

        private void OnDisable()
        {
            inputController.MouseClick -= OnMouseClick;
        }

        private void OnMouseClick(Vector2 mousePosition)
        {
            Ray ray = _mainCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _itemLayerMask))
            {
                // We check for null in HasInventory 
                if (hasInventory.PickupItem(hit.collider.GetComponent<Item>()))
                {
                    Destroy(hit.collider.gameObject);
                }
                else
                {
                    // May be create enum with all (3) possible outcomes and use switch instead.
                    // Or check for null in this script.
                    Debug.Log("Inventory is full or item is not existing");
                }
            }
        }
    }
}