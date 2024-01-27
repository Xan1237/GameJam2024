using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class PushButton : MonoBehaviour
{
    public UnityEvent ButtonPressed;
    public UnityEvent ButtonDepressed;

    private Animator _animator;

    private bool _isPressed;
    private bool _lastState = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _isPressed = true;
    }

    private void FixedUpdate()
    {
        if (_lastState != _isPressed)
        {
            _lastState = _isPressed;

            if (_isPressed)
            {
                ButtonPressed?.Invoke();
                _animator.SetBool("IsPressed", true);
            }
            else
            {
                ButtonDepressed?.Invoke();
                _animator.SetBool("IsPressed", false);
            }
        }

        _isPressed = false;
    }
}
