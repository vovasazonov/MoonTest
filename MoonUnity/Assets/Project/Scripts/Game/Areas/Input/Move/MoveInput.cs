using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Scripts.Game.Areas.Input.Move
{
    public sealed class MoveInput : IMoveInput, IDisposable
    {
        public event Action Updated;

        private readonly InputAction _inputAction;
        private Vector2 _direction;

        public Vector2 Direction
        {
            get => _direction;
            private set
            {
                _direction = value;
                CallUpdated();
            }
        }

        public MoveInput(InputAction inputAction)
        {
            _inputAction = inputAction;
            AddListeners();
        }

        private void AddListeners()
        {
            _inputAction.performed += OnInput;
            _inputAction.canceled += OnInput;
        }

        private void RemoveListeners()
        {
            _inputAction.performed -= OnInput;
            _inputAction.canceled -= OnInput;
        }

        private void OnInput(InputAction.CallbackContext context)
        {
            Direction = context.ReadValue<Vector2>();
        }

        private void CallUpdated()
        {
            Updated?.Invoke();
        }

        public void Dispose()
        {
            RemoveListeners();
        }
    }
}