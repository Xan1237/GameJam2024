using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _deathY = -10f;

    private void Update()
    {
        if (transform.position.y < _deathY)
        {
            GameManager.Instance.RestartLevel();
        }
    }
}
