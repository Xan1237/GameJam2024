using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completedFive : MonoBehaviour
{
    private Image _buttonFive;
    // Start is called before the first frame update
    void Start()
    {
            if(PlayerPrefs.GetInt("levelFive") == 1){
             _buttonFive = GetComponent<Image>();
            _buttonFive.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
