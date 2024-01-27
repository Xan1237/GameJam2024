using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonclickOne : MonoBehaviour
{
    private Image _buttonOne;



    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("levelOne") == 1){
             _buttonOne = GetComponent<Image>();
            _buttonOne.color = Color.cyan;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
