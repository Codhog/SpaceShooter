using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UImanager : MonoBehaviour {

    public Text scoreText;
    int score;

	// Use this for initialization
	void Start () {
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}
    void scoreUpdate()
    {
        score += 1;
    }
    public void Pause()
    {
        if (Time.timeScale == 1) {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
