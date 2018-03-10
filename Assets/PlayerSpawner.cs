using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject playerInstance;
    public int numlives = 4;
    float respawnTimer;

    // Use this for initialization
    void Start()
    {
        SpawnPlayer();

    }
    void SpawnPlayer()
    {
        numlives--;
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "Playership";
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInstance == null)
        {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
        else;
    }
    void OnGUI()
    {
        if (numlives > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Lives left: " + numlives);
        }


        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Game Over!");
        }
    }
}
