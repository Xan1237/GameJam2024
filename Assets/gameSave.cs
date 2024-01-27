using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        saveData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveData(){
        PlayerPrefs.SetInt("levelOne", 0);
        PlayerPrefs.SetInt("levelTwo", 0);
        PlayerPrefs.SetInt("levelThree", 0);
        PlayerPrefs.SetInt("levelFour", 0);
        PlayerPrefs.SetInt("levelFive", 0);
        PlayerPrefs.SetInt("levelSix", 0);
 
    }


}
