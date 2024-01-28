using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private LaughMeterUI _laughUI;
    [SerializeField] private float _laughterDecay = 5f;
    [SerializeField] private float _laughterRequirement = 100f;

    private float _laughAmount = 0f;

    private bool _levelWon = false;

    private void Update()
    {
        if (!_levelWon)
            _laughAmount -= Time.deltaTime * _laughterDecay;

        if (_laughAmount < 0f)
        {
            _laughAmount = 0f;
        }

        _laughUI.SetLaughAmount(_laughAmount / _laughterRequirement);
    }

    public void AddLaughter(float amount)
    {
        _laughAmount += amount;

        if (_laughAmount >= _laughterRequirement)
        {
            _laughAmount = _laughterRequirement;
            _levelWon = true;
            StartCoroutine(NextLevel());
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
