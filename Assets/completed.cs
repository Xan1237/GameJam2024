using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completed : MonoBehaviour
{
    private Image _buttonTwo;
    // Start is called before the first frame update
    void Start()
    {
            if(PlayerPrefs.GetInt("levelTwo") == 1){
             _buttonTwo = GetComponent<Image>();
            _buttonTwo.color = Color.cyan;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
