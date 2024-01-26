using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunScript : MonoBehaviour
{
    [SerializeField] private float distance = 3f;
    [SerializeField] private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time * speed) * distance;
        float y = Mathf.Sin(Time.time * speed) * distance;

        transform.position = new Vector2(x, y);
    }
}
