using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




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
        text2.transform.position = pos;
    }
}
