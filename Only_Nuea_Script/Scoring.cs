using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    [SerializeField] Text ScoreCount;
    [SerializeField] Text HighscoreCount;
    public int Score;
    int Highscore;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ShowingScore();
        CheckHS();
    }

    public void ShowingScore()
    {
        ScoreCount.text = "SCORE: " + Score.ToString();
    }

    public void CheckHS()
    {
        HighscoreCount.text = $"HIGHSCORE: {PlayerPrefs.GetInt("HIGHSCORE: ", 0)}";

        if(Score > PlayerPrefs.GetInt("HIGHSCORE: ", 0))
        {
            PlayerPrefs.SetInt("HIGHSCORE: ", Score);
        }
    }

    public void ResetHS() 
    {
        PlayerPrefs.DeleteAll();
        HighscoreCount.text = "0";
    }
}
