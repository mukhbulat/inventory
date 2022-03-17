using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Managers
{
    public class InputController : MonoBehaviour
    {
        public bool IsMouseActive { get; private set; } = true;

        private EventSystem _currentEventSystem;
        public event Action<Vector2> MouseClick;

        private void Awake()
        {
            _currentEventSystem = EventSystem.current;
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (_currentEventSystem.IsPointerOverGameObject()) return;
                MouseClick?.Invoke(Input.mousePosition);
            }
        }
    }
}