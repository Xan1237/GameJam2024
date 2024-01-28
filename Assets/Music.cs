using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : Singleton<Music>
{
    [SerializeField] private float _menuVolume = 1f;
    [SerializeField] private float _gameVolume = 0.1f;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        _audioSource.volume = SceneManager.GetActiveScene().name == "MainMenu" ? _menuVolume : _gameVolume;
    }
}
