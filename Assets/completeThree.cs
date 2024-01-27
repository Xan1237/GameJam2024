using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completedThree : MonoBehaviour
{
    private Image _buttonThree;
    // Start is called before the first frame update
    void Start()
    {
            if(PlayerPrefs.GetInt("levelThree") == 1){
             _buttonThree = GetComponent<Image>();
            _buttonThree.color = Color.cyan;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
