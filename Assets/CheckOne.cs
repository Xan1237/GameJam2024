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
    public Image checkSeven;


    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
      check.enabled = false;
          checkTwo.enabled = false;
          checkThree.enabled = false;
          checkFour.enabled = false;
          checkFive.enabled = false;
          checkSix.enabled = false;
          checkSix.enabled=false;
          checkSeven.enabled=false;
          if(PlayerPrefs.GetInt("levelOne") == 1){
            check.enabled = true;
          }
           if(PlayerPrefs.GetInt("levelTwo") == 1){
            checkTwo.enabled = true;
          }
           if(PlayerPrefs.GetInt("levelThree") == 1){
            checkThree.enabled = true;
          }
            if(PlayerPrefs.GetInt("levelThree") == 1){
                checkThree.enabled = true;
            }
            if(PlayerPrefs.GetInt("levelFour") == 1){
                checkFour.enabled = true;
          }
          if(PlayerPrefs.GetInt("levelFive") == 1){
            checkFive.enabled = true;
          }
          if(PlayerPrefs.GetInt("levelSix") == 1){
            checkSix.enabled = true;
            }
          if(PlayerPrefs.GetInt("levelSeven") == 1){
            checkSeven.enabled = true;
            }
    }
}
