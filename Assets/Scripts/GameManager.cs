using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private LaughMeterUI _laughUI;
    [SerializeField] private float _laughterDecay = 5f;
    [SerializeField] private float _laughterRequirement = 100f;

    private float _laughAmount = 0f;

    private void Update()
    {
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
            Debug.Log("Win condition");
        }
    }
}
