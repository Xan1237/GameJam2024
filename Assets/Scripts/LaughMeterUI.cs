using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughMeterUI : MonoBehaviour
{
    [SerializeField] private Transform _arrow;

    private void Update()
    {
        float amount = (Mathf.Sin(Time.time) + 1f) / 2f;
        SetLaughAmount(amount);
    }

    public void SetLaughAmount(float amount)
    {
        float rotation = 45f - (amount * 75f);
        _arrow.transform.localEulerAngles = new Vector3(0f, 0f, rotation);
    }
}
