using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FacePlayer : MonoBehaviour
{
    Transform player;
    public float rotSpeed = 90f;

    void Update()
    {
        if (player == null)
        {
            GameObject go = GameObject.Find("Playership");

            if (go != null)
            {
                player = go.transform;
            }
        }
        if (player == null)
            return;

        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);

    }
}
