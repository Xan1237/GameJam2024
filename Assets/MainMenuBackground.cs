using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackground : MonoBehaviour
{
    [SerializeField] private Background _background;

    private void Start()
    {
        _background.GenerateBackground();
    }
}
