using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameMenu : MonoBehaviour
{

    public GameObject pannel;



    // Start is called before the first frame update
    void Start()
    {
        pannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("Escape")){
        pannel.SetActive(true);
      } 
    }
}
