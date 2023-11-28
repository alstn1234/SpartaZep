using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookDirection : MonoBehaviour
{
    private SpriteRenderer _playerRenderer;
    private PlayerController _controller;

    private bool _lookLeft;
    private int _childIdx;
    //= (int)PlayerData.Instance.characterName;


    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        ChangePlayerData();
    }

    private void Start()
    {
        _controller.OnLookEvent += SetDirection;
        PlayerData.Instance.ChangeData += ChangePlayerData;
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

    private void ChangePlayerData()
    {
        _childIdx = (int)PlayerData.Instance.characterName;
        _playerRenderer = transform.GetChild(_childIdx).GetComponent<SpriteRenderer>();
    }
}
