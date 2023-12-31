using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    Controls controls;

    public Vector2 Movement {  get; private set; }
    public event Action Action;

    private void Start()
    {
        controls = new Controls();
        controls.Player.AddCallbacks(this);
        controls.Player.Enable();
    }


    public void OnMovement(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.performed) Action?.Invoke();
    }
}
