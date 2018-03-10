using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Vector3 bulletoffset = new Vector3(0, 0.5f, 0);

    public float fireDelay = 0.23f;
    float cooldownTimer = 0;


    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            Debug.Log("shooting");
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletoffset;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = gameObject.layer;
        }

    }
}
