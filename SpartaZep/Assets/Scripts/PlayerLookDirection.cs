using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookDirection : MonoBehaviour
{
    private SpriteRenderer _playerRenderer;
    private PlayerController _controller;
    private bool _lookLeft;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _playerRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _controller.OnLookEvent += SetDirection;
    }

    public void SetDirection(Vector2 direction)
    {
        PlayerSetDirection(direction);
    }

    private void PlayerSetDirection(Vector2 direction)
    {
        _lookLeft = direction.x < 0f ? true : false;

        _playerRenderer.flipX = _lookLeft;
    }
}
