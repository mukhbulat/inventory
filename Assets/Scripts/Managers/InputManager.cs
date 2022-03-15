using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        public bool IsMouseActive { get; private set; } = true;

        private EventSystem _currentEventSystem = EventSystem.current;
        public event Action<Vector2> MouseClick;

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