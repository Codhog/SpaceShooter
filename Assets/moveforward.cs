﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour {
    public float maxSpeed = 5f;


		
	
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime);
        pos += transform.rotation * velocity;
        transform.position = pos;

    }
}
