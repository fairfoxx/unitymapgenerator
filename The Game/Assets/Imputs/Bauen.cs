//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Imputs/Bauen.inputactions
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

public partial class @Bauen : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Bauen()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Bauen"",
    ""maps"": [
        {
            ""name"": ""Buildings"",
            ""id"": ""e1e6dcf1-0bd1-45f6-8067-6e5869570c49"",
            ""actions"": [
                {
                    ""name"": ""Build"",
                    ""type"": ""Button"",
                    ""id"": ""8d5a7c11-64f5-402a-9ae6-2b0e22b81297"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""a43a526c-c58c-4574-9cdb-67198d6d5415"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e14c26d-f553-4f4d-b645-b1fb883c99b2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Build"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""805fef7a-3b16-4014-85b0-d1c125ae5bb4"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Buildings
        m_Buildings = asset.FindActionMap("Buildings", throwIfNotFound: true);
        m_Buildings_Build = m_Buildings.FindAction("Build", throwIfNotFound: true);
        m_Buildings_Rotate = m_Buildings.FindAction("Rotate", throwIfNotFound: true);
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

    // Buildings
    private readonly InputActionMap m_Buildings;
    private IBuildingsActions m_BuildingsActionsCallbackInterface;
    private readonly InputAction m_Buildings_Build;
    private readonly InputAction m_Buildings_Rotate;
    public struct BuildingsActions
    {
        private @Bauen m_Wrapper;
        public BuildingsActions(@Bauen wrapper) { m_Wrapper = wrapper; }
        public InputAction @Build => m_Wrapper.m_Buildings_Build;
        public InputAction @Rotate => m_Wrapper.m_Buildings_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Buildings; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BuildingsActions set) { return set.Get(); }
        public void SetCallbacks(IBuildingsActions instance)
        {
            if (m_Wrapper.m_BuildingsActionsCallbackInterface != null)
            {
                @Build.started -= m_Wrapper.m_BuildingsActionsCallbackInterface.OnBuild;
                @Build.performed -= m_Wrapper.m_BuildingsActionsCallbackInterface.OnBuild;
                @Build.canceled -= m_Wrapper.m_BuildingsActionsCallbackInterface.OnBuild;
                @Rotate.started -= m_Wrapper.m_BuildingsActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_BuildingsActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_BuildingsActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_BuildingsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Build.started += instance.OnBuild;
                @Build.performed += instance.OnBuild;
                @Build.canceled += instance.OnBuild;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public BuildingsActions @Buildings => new BuildingsActions(this);
    public interface IBuildingsActions
    {
        void OnBuild(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
