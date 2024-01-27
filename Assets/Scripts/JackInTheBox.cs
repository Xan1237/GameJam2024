using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class JackInTheBox : MonoBehaviour
{
    [SerializeField] private float _popInterval = 3f;

    private Animator _animator;

    private float _timer = 0f;
    private bool _popped = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        _timer = _popInterval;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0f)
        {
            _timer = _popInterval;
            _popped = !_popped;
        }

        _animator.SetBool("IsPopped", _popped);
    }
}
