using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _deathY = -10f;
    [SerializeField] private Transform _pickup;

    private WoopieCushion _cushion;

    private void Update()
    {
        if (transform.position.y < _deathY)
        {
            GameManager.Instance.RestartLevel();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_pickup.childCount == 0)
            {
                if (_cushion != null)
                {
                    _cushion.transform.parent = _pickup;
                    _cushion.transform.localPosition = Vector2.zero;
                }
            }
            else
            {
                _pickup.GetChild(0).parent = null;
            }
        }
    }

    public void SetCushion(WoopieCushion cushion)
    {
        if (_cushion == null)
            _cushion = cushion;
    }

    public void RemoveCushion(WoopieCushion cushion)
    {
        if (_cushion == cushion)
            _cushion = null;
    }
}
