using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aa : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text score;
    [SerializeField] Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        int number = Forever_ShowCount_score1.lastScore1;
        score.text = "Score : " + number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore1", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = "High Score : " + number.ToString();
        }
    }
}
