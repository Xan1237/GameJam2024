using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class PushButton : MonoBehaviour
{
    [SerializeField] private AudioClip _pressSound;
    [SerializeField] private AudioClip _depressSound;

    public UnityEvent ButtonPressed;
    public UnityEvent ButtonDepressed;

    private Animator _animator;
    private AudioSource _audioSource;

    private bool _isPressed;
    private bool _lastState = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
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
                _audioSource.PlayOneShot(_pressSound);
            }
            else
            {
                ButtonDepressed?.Invoke();
                _animator.SetBool("IsPressed", false);
                _audioSource.PlayOneShot(_depressSound);
            }
        }
        else
        {
            _isPressed = false;
        }
    }
}
