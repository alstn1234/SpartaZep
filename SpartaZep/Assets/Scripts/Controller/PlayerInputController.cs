using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerInputController : PlayerController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue inputValue)
    {
        Vector2 moveInput = inputValue.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue inputValue)
    {
        Vector2 direction = inputValue.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(direction);
        direction = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(direction);
    }
}
