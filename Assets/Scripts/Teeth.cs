using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teeth : MonoBehaviour
{
    [SerializeField] private Transform _teethTransform;
    [SerializeField] private Transform[] _positions;
    [SerializeField] private float _speed;

    private int _index = 0;
    private bool _forward = true;

    private void Start()
    {
        _teethTransform.position = _positions[0].position;
    }

    private void Update()
    {
        if (Vector2.Distance(_teethTransform.position, _positions[_index].position) > 0.01f)
        {
            _teethTransform.position = Vector2.MoveTowards(_teethTransform.position, _positions[_index].position, Time.deltaTime * _speed);
        }
        else
        {
            _index += _forward ? 1 : -1;
            if (_index >= _positions.Length)
            {
                _index = _positions.Length - 1;
                _forward = false;
            }
            else if (_index <= 0)
            {
                _index = 0;
                _forward = true;
            }
        }
    }
}