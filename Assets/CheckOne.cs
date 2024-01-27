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
    }

    // Update is called once per frame
    void Update()
    {
    }
}
