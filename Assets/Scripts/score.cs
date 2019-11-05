using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreValue;
    private int yourScore;
    private int highscore;
    public Text highScore;
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        yourScore = PlayerPrefs.GetInt("score");
        highScore.text = "High Score: " + highscore.ToString();
        scoreValue.text = "Your Score: " + yourScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
