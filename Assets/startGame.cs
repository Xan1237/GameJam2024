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
        if(PlayerPrefs.GetInt("LevelOne") == 1){
        SceneManager.LoadScene(3);
        }
    }
        public void Button3(){
        if(PlayerPrefs.GetInt("LevelOne") == 1 && PlayerPrefs.GetInt("LevelTwo") ==1){
        SceneManager.LoadScene(4);
        }
        }
        public void Button4(){
            if(PlayerPrefs.GetInt("LevelOne") == 1 && PlayerPrefs.GetInt("LevelTwo") ==1 && PlayerPrefs.GetInt("LevelThree") == 1){
            SceneManager.LoadScene(5);
        }
    }
        public void Button5(){
            if(PlayerPrefs.GetInt("LevelOne") == 1 && PlayerPrefs.GetInt("LevelTwo") ==1 && PlayerPrefs.GetInt("LevelThree") == 1 && PlayerPrefs.GetInt("LevelFour") == 1){
            SceneManager.LoadScene(6);
        }
    }
    public void Button6(){
        if(PlayerPrefs.GetInt("LevelOne") == 1 && PlayerPrefs.GetInt("LevelTwo") ==1 && PlayerPrefs.GetInt("LevelThree") == 1 && PlayerPrefs.GetInt("LevelFour")==1 && PlayerPrefs.GetInt("LevelFive")==1){
        SceneManager.LoadScene(7);
        }
    }


}
