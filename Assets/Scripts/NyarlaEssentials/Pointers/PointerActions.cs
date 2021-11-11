// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/NyarlaEssentials/Pointers/PointerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PointerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PointerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PointerActions"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""c300bc73-4668-49d3-91c2-aedaffaa4784"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""a3d04975-5c73-4b4c-a6ca-95bd970b9354"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""360009cd-f1d6-4a66-b1a7-faa27247a94d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""Button"",
                    ""id"": ""075f7738-b300-4335-99df-3a02594ec32e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMouse"",
                    ""type"": ""Button"",
                    ""id"": ""6e55d6eb-e88f-41cb-914f-6577ad843f54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMouse"",
                    ""type"": ""Button"",
                    ""id"": ""489b67ca-1431-4540-bad4-826db9efc61f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleMouse"",
                    ""type"": ""Button"",
                    ""id"": ""2a01e055-7e9b-489a-9077-2e4c31f5b215"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftDouble"",
                    ""type"": ""Button"",
                    ""id"": ""c7113a04-879d-4535-9791-92be40f664af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightDouble"",
                    ""type"": ""Button"",
                    ""id"": ""86b8adef-b7e7-413c-9c71-4b3905c7fd93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleDouble"",
                    ""type"": ""Button"",
                    ""id"": ""a2dad4b4-ec19-481f-8abd-2f1bbfc1eebb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b17660e8-0230-4b96-8f64-be401d059b17"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87961dac-ff92-4899-8d84-c01efaf5ad21"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba87b9f4-d9a7-4f4f-82b6-70b9c283b44c"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d816cfc-cb8b-405e-b24d-492c94073b37"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""LeftMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4deb0c1d-68f7-42e4-b898-df7e3f4b9c1f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""RightMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29db7115-caa8-41e7-89eb-b81043cf97fa"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""MiddleMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef27c6cf-4dd9-4d8c-b278-41c96623f5f1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""MultiTap(tapDelay=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftDouble"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05b7300a-493b-474a-bc8f-18980778885a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""MultiTap(tapDelay=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightDouble"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eb8a944-3b82-435a-bd88-c1542b1ccebd"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": ""MultiTap(tapDelay=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleDouble"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""id"": ""b99b3957-adb7-40b2-9b75-b8d3942c30b3"",
            ""actions"": [
                {
                    ""name"": ""TapPosition"",
                    ""type"": ""Value"",
                    ""id"": ""c1e169eb-0372-4069-b92e-029ff02969c9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""746e1039-bbcc-48bc-97c8-362769e16aac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DoubleTap"",
                    ""type"": ""Button"",
                    ""id"": ""46d107b6-5619-4a13-b3f6-d707e072aab9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""363dbc6b-51ac-4c05-b4ce-e045f08cb603"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": ""MultiTap(tapDelay=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0622116-67da-474f-81a2-aff8ca604745"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TapPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e60c5288-0e14-41c8-a433-9ed8978d2887"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_LeftClick = m_Mouse.FindAction("LeftClick", throwIfNotFound: true);
        m_Mouse_RightClick = m_Mouse.FindAction("RightClick", throwIfNotFound: true);
        m_Mouse_MiddleClick = m_Mouse.FindAction("MiddleClick", throwIfNotFound: true);
        m_Mouse_LeftMouse = m_Mouse.FindAction("LeftMouse", throwIfNotFound: true);
        m_Mouse_RightMouse = m_Mouse.FindAction("RightMouse", throwIfNotFound: true);
        m_Mouse_MiddleMouse = m_Mouse.FindAction("MiddleMouse", throwIfNotFound: true);
        m_Mouse_LeftDouble = m_Mouse.FindAction("LeftDouble", throwIfNotFound: true);
        m_Mouse_RightDouble = m_Mouse.FindAction("RightDouble", throwIfNotFound: true);
        m_Mouse_MiddleDouble = m_Mouse.FindAction("MiddleDouble", throwIfNotFound: true);
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_TapPosition = m_Touch.FindAction("TapPosition", throwIfNotFound: true);
        m_Touch_Tap = m_Touch.FindAction("Tap", throwIfNotFound: true);
        m_Touch_DoubleTap = m_Touch.FindAction("DoubleTap", throwIfNotFound: true);
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

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_LeftClick;
    private readonly InputAction m_Mouse_RightClick;
    private readonly InputAction m_Mouse_MiddleClick;
    private readonly InputAction m_Mouse_LeftMouse;
    private readonly InputAction m_Mouse_RightMouse;
    private readonly InputAction m_Mouse_MiddleMouse;
    private readonly InputAction m_Mouse_LeftDouble;
    private readonly InputAction m_Mouse_RightDouble;
    private readonly InputAction m_Mouse_MiddleDouble;
    public struct MouseActions
    {
        private @PointerActions m_Wrapper;
        public MouseActions(@PointerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Mouse_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Mouse_RightClick;
        public InputAction @MiddleClick => m_Wrapper.m_Mouse_MiddleClick;
        public InputAction @LeftMouse => m_Wrapper.m_Mouse_LeftMouse;
        public InputAction @RightMouse => m_Wrapper.m_Mouse_RightMouse;
        public InputAction @MiddleMouse => m_Wrapper.m_Mouse_MiddleMouse;
        public InputAction @LeftDouble => m_Wrapper.m_Mouse_LeftDouble;
        public InputAction @RightDouble => m_Wrapper.m_Mouse_RightDouble;
        public InputAction @MiddleDouble => m_Wrapper.m_Mouse_MiddleDouble;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightClick;
                @MiddleClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleClick;
                @LeftMouse.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftMouse;
                @LeftMouse.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftMouse;
                @LeftMouse.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftMouse;
                @RightMouse.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightMouse;
                @RightMouse.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightMouse;
                @RightMouse.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightMouse;
                @MiddleMouse.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleMouse;
                @MiddleMouse.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleMouse;
                @MiddleMouse.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleMouse;
                @LeftDouble.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftDouble;
                @LeftDouble.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftDouble;
                @LeftDouble.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftDouble;
                @RightDouble.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightDouble;
                @RightDouble.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightDouble;
                @RightDouble.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnRightDouble;
                @MiddleDouble.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleDouble;
                @MiddleDouble.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleDouble;
                @MiddleDouble.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMiddleDouble;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @LeftMouse.started += instance.OnLeftMouse;
                @LeftMouse.performed += instance.OnLeftMouse;
                @LeftMouse.canceled += instance.OnLeftMouse;
                @RightMouse.started += instance.OnRightMouse;
                @RightMouse.performed += instance.OnRightMouse;
                @RightMouse.canceled += instance.OnRightMouse;
                @MiddleMouse.started += instance.OnMiddleMouse;
                @MiddleMouse.performed += instance.OnMiddleMouse;
                @MiddleMouse.canceled += instance.OnMiddleMouse;
                @LeftDouble.started += instance.OnLeftDouble;
                @LeftDouble.performed += instance.OnLeftDouble;
                @LeftDouble.canceled += instance.OnLeftDouble;
                @RightDouble.started += instance.OnRightDouble;
                @RightDouble.performed += instance.OnRightDouble;
                @RightDouble.canceled += instance.OnRightDouble;
                @MiddleDouble.started += instance.OnMiddleDouble;
                @MiddleDouble.performed += instance.OnMiddleDouble;
                @MiddleDouble.canceled += instance.OnMiddleDouble;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_TapPosition;
    private readonly InputAction m_Touch_Tap;
    private readonly InputAction m_Touch_DoubleTap;
    public struct TouchActions
    {
        private @PointerActions m_Wrapper;
        public TouchActions(@PointerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TapPosition => m_Wrapper.m_Touch_TapPosition;
        public InputAction @Tap => m_Wrapper.m_Touch_Tap;
        public InputAction @DoubleTap => m_Wrapper.m_Touch_DoubleTap;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @TapPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTapPosition;
                @TapPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTapPosition;
                @TapPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTapPosition;
                @Tap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTap;
                @DoubleTap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DoubleTap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DoubleTap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TapPosition.started += instance.OnTapPosition;
                @TapPosition.performed += instance.OnTapPosition;
                @TapPosition.canceled += instance.OnTapPosition;
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @DoubleTap.started += instance.OnDoubleTap;
                @DoubleTap.performed += instance.OnDoubleTap;
                @DoubleTap.canceled += instance.OnDoubleTap;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnLeftMouse(InputAction.CallbackContext context);
        void OnRightMouse(InputAction.CallbackContext context);
        void OnMiddleMouse(InputAction.CallbackContext context);
        void OnLeftDouble(InputAction.CallbackContext context);
        void OnRightDouble(InputAction.CallbackContext context);
        void OnMiddleDouble(InputAction.CallbackContext context);
    }
    public interface ITouchActions
    {
        void OnTapPosition(InputAction.CallbackContext context);
        void OnTap(InputAction.CallbackContext context);
        void OnDoubleTap(InputAction.CallbackContext context);
    }
}