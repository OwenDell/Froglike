using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class HP_Script : MonoBehaviour
{
    int health = 5;
    public Text healthText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "HEALTH : " + health;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }


    }
}
