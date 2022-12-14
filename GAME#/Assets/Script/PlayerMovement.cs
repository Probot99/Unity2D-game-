using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public  float Speed ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");
        Vector2 pos = transform.position;

        pos.x += a*Speed* Time.deltaTime;
        pos.y += b*Speed* Time.deltaTime;
        transform.position = pos;

        
    }
}
