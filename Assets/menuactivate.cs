using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuactivate : MonoBehaviour
{

    public GameObject pannel;
    public GameObject button1;
    public GameObject button2;
    bool menuUp = false;


    // Start is called before the first frame update
    void Start()
    {
        pannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape) && menuUp == false){
        pannel.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        menuUp= true;
      } 
      else if(Input.GetKeyDown(KeyCode.Escape) && menuUp == true){
        pannel.SetActive(false);
        menuUp=false;
        button1.SetActive(false);
        button2.SetActive(false);
      }
    }




    public  void button1Active(){
        SceneManager.LoadScene(1);
    }
}
