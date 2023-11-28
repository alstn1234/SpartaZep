using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController _playerController;
    private Rigidbody2D _rb;
    private Animator _animator;

    private Vector2 _movementDirection = Vector2.zero;
    private int _childIdx;
    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _childIdx = (int)PlayerData.Instance.characterName;
        _rb = GetComponent<Rigidbody2D>();
        _animator = transform.GetChild(_childIdx).GetComponent<Animator>();
    }
    private void Start()
    {
        _playerController.OnMoveEvent += Move;
        PlayerData.Instance.ChangeData += ChangePlayerData;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        if(_movementDirection != Vector2.zero)
        {
            _animator.SetBool("IsMove", true);
        }
        else
        {
            _animator.SetBool("IsMove", false);
        }
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= PlayerData.Instance.speed;
        _rb.velocity = direction;
    }

    private void ChangePlayerData()
    {
        _childIdx = (int)PlayerData.Instance.characterName;
        _animator = transform.GetChild(_childIdx).GetComponent<Animator>();
    }

}
