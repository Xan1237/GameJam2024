using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadSceneAsync(2);

    }

    public void Button1(){
        SceneManager.LoadScene(2);
    }


    public void Button2(){
        if(PlayerPrefs.GetInt("levelOne") == 1){
        SceneManager.LoadScene(3);
        }
    }
        public void Button3(){
        if(PlayerPrefs.GetInt("levelOne") == 1 && PlayerPrefs.GetInt("levelTwo") ==1){
        SceneManager.LoadScene(4);
        }
        }
        public void Button4(){
            if(PlayerPrefs.GetInt("levelOne") == 1 && PlayerPrefs.GetInt("levelTwo") ==1 && PlayerPrefs.GetInt("levelThree") == 1){
            SceneManager.LoadScene(5);
        }
    }
        public void Button5(){
            if(PlayerPrefs.GetInt("levelOne") == 1 && PlayerPrefs.GetInt("levelTwo") ==1 && PlayerPrefs.GetInt("levelThree") == 1 && PlayerPrefs.GetInt("levelFour") == 1){
            SceneManager.LoadScene(6);
        }
    }
    public void Button6(){
        if(PlayerPrefs.GetInt("levelOne") == 1 && PlayerPrefs.GetInt("levelTwo") ==1 && PlayerPrefs.GetInt("levelThree") == 1 && PlayerPrefs.GetInt("levelFour")==1 && PlayerPrefs.GetInt("levelFive")==1){
        SceneManager.LoadScene(7);
        }
    }

    public void Button7(){
        if(PlayerPrefs.GetInt("levelOne") == 1 && PlayerPrefs.GetInt("levelTwo") ==1 && PlayerPrefs.GetInt("levelThree") == 1 && PlayerPrefs.GetInt("levelFour")==1 && PlayerPrefs.GetInt("levelFive")==1 && PlayerPrefs.GetInt("levelSix") ==1){
        SceneManager.LoadScene(8);
        }     
    }

}
