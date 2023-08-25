using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager Instance;
    public Text scoreText;
    public Text highScoreText;
    int score = 0;
    int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
       // scoreText.text = score.ToString() + " POints";
        scoreText.text = "Score is :" + score.ToString();
        highScoreText.text = "High Score:" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void AddPoint()
    {
        score +=5;
        scoreText.text = score.ToString() + " POINTS";
        if (highScore < score)
        {
            PlayerPrefs.SetInt("highScore", score);
            highScoreText.text = "High Score:" + score.ToString();
        }

    }
    private void Awake()
    {
        Instance=this;
    }

}
