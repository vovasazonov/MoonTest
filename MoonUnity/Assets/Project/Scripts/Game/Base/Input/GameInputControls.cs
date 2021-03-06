//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/Project/Scripts/Game/Base/Input/GameInputControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Game.Areas.Inputs
{
    public partial class @GameInputControls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInputControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputControls"",
    ""maps"": [
        {
            ""name"": ""Joystick"",
            ""id"": ""20db9ac4-30cd-4c15-b8ee-75f5ffb8eccc"",
            ""actions"": [
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""4f7745c8-f45b-4936-92e6-1583486eb854"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""91e7faf6-c0ed-4c57-9ac3-11d94f085605"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4bc9320c-63f0-4741-829d-426313082591"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1438e9ef-4505-42ac-8f8e-36224a3839cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f08b41cc-fde8-4f6e-a216-9fddf089aae2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""18406623-38b9-41bf-a3cc-25daab3f9ee3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f532cba7-2f94-41ab-8c00-3d843316ccc6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1f3ae1b0-acf5-4d5e-8b9b-eadfc9480e26"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""b8e0ea73-99e8-4c75-a217-40feab4aa39c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6668b538-4649-463d-a685-511f58ebd1a9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aaf401d7-a1c3-4b3d-9aa4-0fa8e2cfa117"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5a0b9f94-f864-487e-82c7-ad061d60476a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ad50a89c-a730-498d-85be-a9d82e43d6d0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c41a6c5-1fc4-47ae-b3bf-b016b33f42ad"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""NavigationBar"",
            ""id"": ""772c4d16-7379-4459-ad4d-a5ab37d10a50"",
            ""actions"": [
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""71e9ac8a-bdd5-42b7-9ba1-d1cdb5b12747"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8e559b9e-4cc8-4b95-98ae-5fc17afe39e2"",
                    ""path"": ""*/{Back}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pointer"",
            ""id"": ""b92ab2bc-d83c-4da9-97cd-379f17a8b187"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""5242a288-bffc-466a-9b61-1e9a02017191"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PointerContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""707f24bc-e261-47cb-8c43-15c91aca0f2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PointerPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""92b3b05d-6432-4fa9-a89b-f8d8e8047fe2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PointerStartPosition"",
                    ""type"": ""Value"",
                    ""id"": ""01dead93-79bf-452f-b03e-77212aecba06"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1a5c023-23c5-42da-b86d-e6807902b9b4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13a5cd2b-59d5-4b52-bfcf-a84804e5d3a2"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2707088a-5878-4261-8c83-7a24fe457359"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""265e6c9c-0ebc-400d-8284-a6b962f919a6"",
                    ""path"": ""<Touchscreen>/primaryTouch/startPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerStartPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Joystick
            m_Joystick = asset.FindActionMap("Joystick", throwIfNotFound: true);
            m_Joystick_LeftStick = m_Joystick.FindAction("LeftStick", throwIfNotFound: true);
            m_Joystick_RightStick = m_Joystick.FindAction("RightStick", throwIfNotFound: true);
            // NavigationBar
            m_NavigationBar = asset.FindActionMap("NavigationBar", throwIfNotFound: true);
            m_NavigationBar_Back = m_NavigationBar.FindAction("Back", throwIfNotFound: true);
            // Pointer
            m_Pointer = asset.FindActionMap("Pointer", throwIfNotFound: true);
            m_Pointer_Newaction = m_Pointer.FindAction("New action", throwIfNotFound: true);
            m_Pointer_PointerContact = m_Pointer.FindAction("PointerContact", throwIfNotFound: true);
            m_Pointer_PointerPosition = m_Pointer.FindAction("PointerPosition", throwIfNotFound: true);
            m_Pointer_PointerStartPosition = m_Pointer.FindAction("PointerStartPosition", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Joystick
        private readonly InputActionMap m_Joystick;
        private IJoystickActions m_JoystickActionsCallbackInterface;
        private readonly InputAction m_Joystick_LeftStick;
        private readonly InputAction m_Joystick_RightStick;
        public struct JoystickActions
        {
            private @GameInputControls m_Wrapper;
            public JoystickActions(@GameInputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftStick => m_Wrapper.m_Joystick_LeftStick;
            public InputAction @RightStick => m_Wrapper.m_Joystick_RightStick;
            public InputActionMap Get() { return m_Wrapper.m_Joystick; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(JoystickActions set) { return set.Get(); }
            public void SetCallbacks(IJoystickActions instance)
            {
                if (m_Wrapper.m_JoystickActionsCallbackInterface != null)
                {
                    @LeftStick.started -= m_Wrapper.m_JoystickActionsCallbackInterface.OnLeftStick;
                    @LeftStick.performed -= m_Wrapper.m_JoystickActionsCallbackInterface.OnLeftStick;
                    @LeftStick.canceled -= m_Wrapper.m_JoystickActionsCallbackInterface.OnLeftStick;
                    @RightStick.started -= m_Wrapper.m_JoystickActionsCallbackInterface.OnRightStick;
                    @RightStick.performed -= m_Wrapper.m_JoystickActionsCallbackInterface.OnRightStick;
                    @RightStick.canceled -= m_Wrapper.m_JoystickActionsCallbackInterface.OnRightStick;
                }
                m_Wrapper.m_JoystickActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @LeftStick.started += instance.OnLeftStick;
                    @LeftStick.performed += instance.OnLeftStick;
                    @LeftStick.canceled += instance.OnLeftStick;
                    @RightStick.started += instance.OnRightStick;
                    @RightStick.performed += instance.OnRightStick;
                    @RightStick.canceled += instance.OnRightStick;
                }
            }
        }
        public JoystickActions @Joystick => new JoystickActions(this);

        // NavigationBar
        private readonly InputActionMap m_NavigationBar;
        private INavigationBarActions m_NavigationBarActionsCallbackInterface;
        private readonly InputAction m_NavigationBar_Back;
        public struct NavigationBarActions
        {
            private @GameInputControls m_Wrapper;
            public NavigationBarActions(@GameInputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Back => m_Wrapper.m_NavigationBar_Back;
            public InputActionMap Get() { return m_Wrapper.m_NavigationBar; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(NavigationBarActions set) { return set.Get(); }
            public void SetCallbacks(INavigationBarActions instance)
            {
                if (m_Wrapper.m_NavigationBarActionsCallbackInterface != null)
                {
                    @Back.started -= m_Wrapper.m_NavigationBarActionsCallbackInterface.OnBack;
                    @Back.performed -= m_Wrapper.m_NavigationBarActionsCallbackInterface.OnBack;
                    @Back.canceled -= m_Wrapper.m_NavigationBarActionsCallbackInterface.OnBack;
                }
                m_Wrapper.m_NavigationBarActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Back.started += instance.OnBack;
                    @Back.performed += instance.OnBack;
                    @Back.canceled += instance.OnBack;
                }
            }
        }
        public NavigationBarActions @NavigationBar => new NavigationBarActions(this);

        // Pointer
        private readonly InputActionMap m_Pointer;
        private IPointerActions m_PointerActionsCallbackInterface;
        private readonly InputAction m_Pointer_Newaction;
        private readonly InputAction m_Pointer_PointerContact;
        private readonly InputAction m_Pointer_PointerPosition;
        private readonly InputAction m_Pointer_PointerStartPosition;
        public struct PointerActions
        {
            private @GameInputControls m_Wrapper;
            public PointerActions(@GameInputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_Pointer_Newaction;
            public InputAction @PointerContact => m_Wrapper.m_Pointer_PointerContact;
            public InputAction @PointerPosition => m_Wrapper.m_Pointer_PointerPosition;
            public InputAction @PointerStartPosition => m_Wrapper.m_Pointer_PointerStartPosition;
            public InputActionMap Get() { return m_Wrapper.m_Pointer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PointerActions set) { return set.Get(); }
            public void SetCallbacks(IPointerActions instance)
            {
                if (m_Wrapper.m_PointerActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_PointerActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_PointerActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_PointerActionsCallbackInterface.OnNewaction;
                    @PointerContact.started -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerContact;
                    @PointerContact.performed -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerContact;
                    @PointerContact.canceled -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerContact;
                    @PointerPosition.started -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerPosition;
                    @PointerPosition.performed -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerPosition;
                    @PointerPosition.canceled -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerPosition;
                    @PointerStartPosition.started -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerStartPosition;
                    @PointerStartPosition.performed -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerStartPosition;
                    @PointerStartPosition.canceled -= m_Wrapper.m_PointerActionsCallbackInterface.OnPointerStartPosition;
                }
                m_Wrapper.m_PointerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                    @PointerContact.started += instance.OnPointerContact;
                    @PointerContact.performed += instance.OnPointerContact;
                    @PointerContact.canceled += instance.OnPointerContact;
                    @PointerPosition.started += instance.OnPointerPosition;
                    @PointerPosition.performed += instance.OnPointerPosition;
                    @PointerPosition.canceled += instance.OnPointerPosition;
                    @PointerStartPosition.started += instance.OnPointerStartPosition;
                    @PointerStartPosition.performed += instance.OnPointerStartPosition;
                    @PointerStartPosition.canceled += instance.OnPointerStartPosition;
                }
            }
        }
        public PointerActions @Pointer => new PointerActions(this);
        public interface IJoystickActions
        {
            void OnLeftStick(InputAction.CallbackContext context);
            void OnRightStick(InputAction.CallbackContext context);
        }
        public interface INavigationBarActions
        {
            void OnBack(InputAction.CallbackContext context);
        }
        public interface IPointerActions
        {
            void OnNewaction(InputAction.CallbackContext context);
            void OnPointerContact(InputAction.CallbackContext context);
            void OnPointerPosition(InputAction.CallbackContext context);
            void OnPointerStartPosition(InputAction.CallbackContext context);
        }
    }
}
