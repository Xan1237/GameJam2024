using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;




public class Credits : MonoBehaviour
{

    public GameObject text2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = text2.transform.position;
        pos.y -= 0.3f;
        if(!(transform.position.y < 300)){
        text2.transform.position = pos;
        }
        
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(0);
    }
}
}
