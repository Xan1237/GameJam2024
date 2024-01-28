using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private AudioClip _openClip;
    [SerializeField] private AudioClip _closeClip;

    private AudioSource _audioSource;

    private bool _doorOpen = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void OpenDoor()
    {
        if (!_doorOpen)
        {
            _doorOpen = true;
            _audioSource.PlayOneShot(_openClip);
        }
    }

    public void CloseDoor()
    {
        if (_doorOpen)
        {
            _doorOpen = false;
            _audioSource.PlayOneShot(_closeClip);
        }
    }
}
