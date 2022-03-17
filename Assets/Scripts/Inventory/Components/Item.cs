using System;
using UnityEngine;

namespace Inventory.Components
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private string itemName;
        [SerializeField] private string description;
        [SerializeField] private int value;
        [SerializeField] private int maxStack = 1;

        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void OnEnable()
        {
            _meshRenderer.enabled = true;
        }

        private void OnDisable()
        {
            _meshRenderer.enabled = false;
        }
    }
}