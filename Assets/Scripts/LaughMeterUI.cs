using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughMeterUI : MonoBehaviour
{
    [SerializeField] private Transform _arrow;

    private float _laughAmount = 0f;

    private void Update()
    {
        float rotation = 45f - (_laughAmount * 80f);
        _arrow.transform.rotation = Quaternion.Lerp(_arrow.transform.rotation, Quaternion.Euler(0f, 0f, rotation), Time.deltaTime);
    }

    public void SetLaughAmount(float amount)
    {
        _laughAmount = amount;
    }
}
