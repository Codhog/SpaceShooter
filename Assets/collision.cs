using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
    float invulnTimer = 0;
    public float invulnPeriod = 0;
    int correctlayer;
    public int health = 1;


    void Start()
    {
        correctlayer = gameObject.layer;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger");
        health--;
        invulnTimer = invulnPeriod;
        gameObject.layer = 10;
    }

    void Update()   
    {
        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0)
        {
            gameObject.layer = correctlayer;
        }
        if (health <= 0)
        {
            die();
        }
    }



    void die()
    {
        Destroy(gameObject);
    }


}

