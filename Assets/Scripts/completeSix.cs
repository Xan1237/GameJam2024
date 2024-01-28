using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class completedSix : MonoBehaviour
{
    private Image _buttonSix;
    // Start is called before the first frame update
    void Start()
    {
            if(PlayerPrefs.GetInt("levelSix") == 1){
             _buttonSix = GetComponent<Image>();
            _buttonSix.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
