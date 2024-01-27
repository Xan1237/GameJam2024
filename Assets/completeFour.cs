using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completeFour : MonoBehaviour
{
    private Image _buttonFour;
    // Start is called before the first frame update
    void Start()
    {
            if(PlayerPrefs.GetInt("levelFour") == 1){
             _buttonFour = GetComponent<Image>();
            _buttonFour.color = Color.cyan;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
