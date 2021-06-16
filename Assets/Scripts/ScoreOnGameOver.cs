using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOnGameOver : MonoBehaviour
{
    public Text Scr;
    public static float highscore;
    public Text highScoreText;
    public static ScoreOnGameOver instance;

    public void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetFloat("HighScore");
            highScoreText.text = "High Score: " + highscore.ToString();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Scr = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Scr.text = "Score: " + ScoreCounter.totalscore;
        UpdateHighScore();
        highScoreText.text = "High Score: " + highscore.ToString();
    }

    public void UpdateHighScore()
    {
        if(ScoreCounter.totalscore > highscore)
        {
            highscore = ScoreCounter.totalscore;

            PlayerPrefs.SetFloat("HighScore", highscore);
        }
    }
}
