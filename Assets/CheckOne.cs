using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOne : MonoBehaviour
{

    public Image check;
    public Image checkTwo;
    public Image checkThree;
    public Image checkFour;
    public Image checkFive;
    public Image checkSix;


    // Start is called before the first frame update
    void Start()
    {
          check.enabled = false;
          checkTwo.enabled = false;
          checkThree.enabled = false;
          checkFour.enabled = false;
          checkFive.enabled = false;
          checkSix.enabled = false;
          if(PlayerPrefs.GetInt("LevelOne") == 1){
            check.enabled = true;
          }
           if(PlayerPrefs.GetInt("LevelTwo") == 1){
            checkTwo.enabled = true;
          }
           if(PlayerPrefs.GetInt("LevelThree") == 1){
            checkThree.enabled = true;
          }
            if(PlayerPrefs.GetInt("LevelThree") == 1){
                checkThree.enabled = true;
            }
            if(PlayerPrefs.GetInt("LevelFour") == 1){
                checkFour.enabled = true;
          }
          if(PlayerPrefs.GetInt("LevelFive") == 1){
            checkFive.enabled = true;
          }
          if(PlayerPrefs.GetInt("LevelSix") == 1){
            checkSix.enabled = true;
            }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
