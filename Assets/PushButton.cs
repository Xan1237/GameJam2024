using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    private bool _isPressed;

    private void OnTriggerStay2D(Collider2D collision)
    {
        _isPressed = true;
    }

    private void FixedUpdate()
    {
        if (_isPressed)
        {
            Debug.Log("Was pressed");
        }

        _isPressed = false;
    }
}
