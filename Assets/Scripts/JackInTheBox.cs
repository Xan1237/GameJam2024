using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class JackInTheBox : MonoBehaviour
{
    [SerializeField] private float _popInterval = 3f;
    [SerializeField] private AudioClip[] _popSounds;

    private Animator _animator;
    private AudioSource _audioSource;

    private float _timer = 0f;
    private bool _popped = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

        _timer = _popInterval;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0f)
        {
            _timer = _popInterval;
            _popped = !_popped;

            if (_popped)
            {
                _audioSource.PlayOneShot(_popSounds[Random.Range(0, _popSounds.Length)]);
            }
        }

        _animator.SetBool("IsPopped", _popped);
    }
}
