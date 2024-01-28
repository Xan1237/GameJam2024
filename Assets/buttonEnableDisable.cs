using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonEnableDisable : MonoBehaviour
{



        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
        public Button button7;
        










    // Start is called before the first frame update
    void Start()
    {
        button2.interactable = PlayerPrefs.GetInt("levelOne") == 1;
        button3.interactable = PlayerPrefs.GetInt("levelTwo") == 1;
        button4.interactable = PlayerPrefs.GetInt("levelThree") == 1;
        button5.interactable = PlayerPrefs.GetInt("levelFour") == 1;
        button6.interactable = PlayerPrefs.GetInt("levelFive") == 1;
        button7.interactable = PlayerPrefs.GetInt("levelSix") == 1;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
