using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    float speed = 5.0f;
    double health = 100.0;
    string playerName = "Warrior";
    bool isDead = false;
    private void Start()
    {
        CalculateTwoNumber();
        Health();

    }
    void CalculateTwoNumber()
    {
        float a = 10;
        float b = 90;
        Debug.Log("sum" + (a + b));
       // int a= 10;
        //int b= 90;
       // int c = a + b;
        Debug.Log(" A  +  B=" + (a*b));
    }
    void Health()
    {
        float health = 100;
        if (health <= 0)
        {
            //if health less then zero then true
            Debug.Log("zeo");


        }
        else if (health < 50)
        {
            Debug.Log("-50");

            // health less than 50 then true 

        }
        else
        {

            Debug.Log("50+");
            //health greater than 50 then true

        }
    } 

     
     
}
