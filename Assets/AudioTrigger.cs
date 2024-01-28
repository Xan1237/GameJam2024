using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        _audioSource.Play();
    }

    public void PlayAudioClip(AudioClip clip)
    {
        _audioSource.PlayOneShot(clip);
    }
}
