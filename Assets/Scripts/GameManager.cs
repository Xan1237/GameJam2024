using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private LaughMeterUI _laughUI;
    [SerializeField] private Background _background;
    [SerializeField] private PlayerController _player;
    [SerializeField] private float _laughterDecay = 5f;
    [SerializeField] private float _laughterRequirement = 100f;

    private AudioSource _audioSource;

    private float _laughAmount = 0f;

    private bool _levelWon = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        float people = (float)SceneManager.GetActiveScene().buildIndex / (SceneManager.sceneCountInBuildSettings - 1) * Random.Range(0.8f, 1f);
        _background.GenerateBackground(people);
    }

    private void Update()
    {
        if (!_levelWon)
            _laughAmount -= Time.deltaTime * _laughterDecay;

        if (_laughAmount < 0f)
        {
            _laughAmount = 0f;
        }

        float laughPercent = _laughAmount / _laughterRequirement;

        _laughUI.SetLaughAmount(laughPercent);
        _background.SetExcitementLevel(laughPercent);
        _audioSource.volume = laughPercent + 0.05f;
    }

    public void AddLaughter(float amount, bool canWin)
    {
        _laughAmount += amount;

        if (_laughAmount >= _laughterRequirement && canWin)
        {
            _laughAmount = _laughterRequirement;
            _levelWon = true;
            _player.TakeAwayControl();
            if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
                StartCoroutine(NextLevelCoroutine());
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoseLevel()
    {
        _player.gameObject.SetActive(false);
        StartCoroutine(LoseLevelCoroutine());
    }

    private IEnumerator LoseLevelCoroutine()
    {
        yield return new WaitForSeconds(3f);

        RestartLevel();
    }

    private IEnumerator NextLevelCoroutine()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
