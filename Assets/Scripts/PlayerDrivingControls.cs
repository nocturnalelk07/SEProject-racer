//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/PlayerDrivingControls.inputactions
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

public partial class @PlayerDrivingControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerDrivingControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerDrivingControls"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""f14be39b-d421-4c97-80f2-1863035daf52"",
            ""actions"": [
                {
                    ""name"": ""Horn"",
                    ""type"": ""Button"",
                    ""id"": ""ab8bbfc9-41f5-4f1a-a8f2-3953233706b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Accelerate/Decelerate"",
                    ""type"": ""Value"",
                    ""id"": ""eb7a0e20-eb7e-4fc8-ae3d-17e8f177fd6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""d32b3b01-970b-4463-8ad1-66fd77d550dd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OpenMenu"",
                    ""type"": ""Button"",
                    ""id"": ""7b645140-6fc0-40bc-8592-bbbb80eddefd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3869a30d-cdb4-451b-bb53-7149c0f28d75"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a5e7c89-f91b-444d-8f37-16a16e4de6b1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Move"",
                    ""id"": ""a4a9fc9f-8616-4f6c-b9d1-41c954734e16"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate/Decelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c53fb1ab-ddf0-454c-afe8-39ae39d68e7b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate/Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""3cbb7dec-963f-4d53-b764-2f6965e2e06a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate/Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ae767cd8-3c3d-4cc7-8ef0-2a298344bb9e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate/Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5a3dbb1e-61d5-49ca-812f-e6d41a5ccfcd"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate/Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""23344f95-bb29-448f-b7ba-7d756e2c07a6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""349b6653-93e0-4f13-9fa7-7cf01eec8a1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f433e7f8-5d91-44f2-a6e8-56f9427e64e4"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""215d4fa7-6692-43be-8416-c92e11ebea9d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ccf37518-be04-4dc2-88e0-8d7f99aade8c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0796e3d3-8f67-406b-935d-c08955fc3b6f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Horn = m_Driving.FindAction("Horn", throwIfNotFound: true);
        m_Driving_AccelerateDecelerate = m_Driving.FindAction("Accelerate/Decelerate", throwIfNotFound: true);
        m_Driving_Turn = m_Driving.FindAction("Turn", throwIfNotFound: true);
        m_Driving_OpenMenu = m_Driving.FindAction("OpenMenu", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private List<IDrivingActions> m_DrivingActionsCallbackInterfaces = new List<IDrivingActions>();
    private readonly InputAction m_Driving_Horn;
    private readonly InputAction m_Driving_AccelerateDecelerate;
    private readonly InputAction m_Driving_Turn;
    private readonly InputAction m_Driving_OpenMenu;
    public struct DrivingActions
    {
        private @PlayerDrivingControls m_Wrapper;
        public DrivingActions(@PlayerDrivingControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horn => m_Wrapper.m_Driving_Horn;
        public InputAction @AccelerateDecelerate => m_Wrapper.m_Driving_AccelerateDecelerate;
        public InputAction @Turn => m_Wrapper.m_Driving_Turn;
        public InputAction @OpenMenu => m_Wrapper.m_Driving_OpenMenu;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void AddCallbacks(IDrivingActions instance)
        {
            if (instance == null || m_Wrapper.m_DrivingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DrivingActionsCallbackInterfaces.Add(instance);
            @Horn.started += instance.OnHorn;
            @Horn.performed += instance.OnHorn;
            @Horn.canceled += instance.OnHorn;
            @AccelerateDecelerate.started += instance.OnAccelerateDecelerate;
            @AccelerateDecelerate.performed += instance.OnAccelerateDecelerate;
            @AccelerateDecelerate.canceled += instance.OnAccelerateDecelerate;
            @Turn.started += instance.OnTurn;
            @Turn.performed += instance.OnTurn;
            @Turn.canceled += instance.OnTurn;
            @OpenMenu.started += instance.OnOpenMenu;
            @OpenMenu.performed += instance.OnOpenMenu;
            @OpenMenu.canceled += instance.OnOpenMenu;
        }

        private void UnregisterCallbacks(IDrivingActions instance)
        {
            @Horn.started -= instance.OnHorn;
            @Horn.performed -= instance.OnHorn;
            @Horn.canceled -= instance.OnHorn;
            @AccelerateDecelerate.started -= instance.OnAccelerateDecelerate;
            @AccelerateDecelerate.performed -= instance.OnAccelerateDecelerate;
            @AccelerateDecelerate.canceled -= instance.OnAccelerateDecelerate;
            @Turn.started -= instance.OnTurn;
            @Turn.performed -= instance.OnTurn;
            @Turn.canceled -= instance.OnTurn;
            @OpenMenu.started -= instance.OnOpenMenu;
            @OpenMenu.performed -= instance.OnOpenMenu;
            @OpenMenu.canceled -= instance.OnOpenMenu;
        }

        public void RemoveCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDrivingActions instance)
        {
            foreach (var item in m_Wrapper.m_DrivingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DrivingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    public interface IDrivingActions
    {
        void OnHorn(InputAction.CallbackContext context);
        void OnAccelerateDecelerate(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnOpenMenu(InputAction.CallbackContext context);
    }
}
