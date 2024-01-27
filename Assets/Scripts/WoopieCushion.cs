using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WoopieCushion : MonoBehaviour
{
    [SerializeField] private float _velocityMultiplier = 1.7f;
    [SerializeField] private float _velocityConstant = 15f;
    [SerializeField] private float _inflateTime = 5f;

    private Animator _animator;
    private bool _inflated = true;
    private float _timer = 0f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool("IsInflated", _inflated);

        if (!_inflated)
        {
            if (_timer > 0f)
            {
                _timer -= Time.deltaTime;
            } else
            {
                _inflated = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_inflated)
        {
            if (collision.TryGetComponent(out PlayerController player))
            {
                Vector2 newVelocity = player.Velocity;
                if (newVelocity.y < 0f)
                {
                    _inflated = false;
                    _timer = _inflateTime;
                    newVelocity.y = _velocityConstant + (newVelocity.y * -_velocityMultiplier);
                    player.SetVelocity(newVelocity, PlayerForce.Burst);
                    GameManager.Instance.AddLaughter(newVelocity.y);
                }
            }
        }
    }
}