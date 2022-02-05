using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public static int scores;

    public Text score;

    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        scores = 0;
        score.text=scores.ToString();
        highScore.text=PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(scores<Points.points)
        {
            scores=Points.points;
            score.text=scores.ToString();
        }
        if(scores > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scores);
            highScore.text = scores.ToString();
        }

    }
}
