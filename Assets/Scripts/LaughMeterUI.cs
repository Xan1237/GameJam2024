using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughMeterUI : MonoBehaviour
{
    [SerializeField] private Transform _arrow;
    [SerializeField] private float _rotationSpeed = 3f;

    private float _laughAmount = 0f;

    private void Update()
    {
        float rotation = -210f + (_laughAmount * 80f);
        _arrow.transform.rotation = Quaternion.Lerp(_arrow.transform.rotation, Quaternion.Euler(0f, 0f, rotation), Time.deltaTime * _rotationSpeed);
    }

    public void SetLaughAmount(float amount)
    {
        _laughAmount = amount;
    }
}
