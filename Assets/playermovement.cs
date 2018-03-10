using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public float maxSpeed = 3f;
    public float rotSpeed = 180f;
    float shipBoundaryRadius = 0.5f;
    public Transform bulletPrefab;
    

    void Start()

    {
        Transform bullet = Instantiate(bulletPrefab) as Transform;
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update () {
        Quaternion rot = transform.rotation;

        float z = rot.eulerAngles.z;

        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        rot = Quaternion.Euler(0, 0, z);

        transform.rotation = rot;

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime);
        pos += rot * velocity;
        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if (pos.x - shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }
        transform.position = pos;
	}
}
