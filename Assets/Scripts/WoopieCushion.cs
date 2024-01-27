using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WoopieCushion : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particles;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _normalColor;
    [SerializeField] private Color _staticColor;
    [SerializeField] private float _velocityMultiplier = 1.7f;
    [SerializeField] private float _velocityConstant = 15f;
    [SerializeField] private float _inflateTime = 5f;
    [SerializeField] private float _maxLaughter = 80f;
    [SerializeField] private bool _isStatic = false;

    private Animator _animator;
    private bool _inflated = true;
    private float _timer = 0f;

    private void OnValidate()
    {
        if (_isStatic)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            _spriteRenderer.color = _staticColor;
        }
        else
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            _spriteRenderer.color = _normalColor;
        }
    }

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
            if (collision.TryGetComponent(out PlayerController controller))
            {
                Vector2 newVelocity = controller.Velocity;
                if (newVelocity.y < 0f)
                {
                    _inflated = false;
                    _timer = _inflateTime;
                    newVelocity.y = _velocityConstant + (newVelocity.y * -_velocityMultiplier);
                    controller.SetVelocity(newVelocity, PlayerForce.Burst);
                    GameManager.Instance.AddLaughter(Mathf.Clamp(newVelocity.y, 0f, _maxLaughter));
                    _particles.Play();
                }
            }
        }

        if (collision.TryGetComponent(out Player player) && !_isStatic)
        {
            player.SetCushion(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player) && !_isStatic)
        {
            player.RemoveCushion(this);
        }
    }
}
