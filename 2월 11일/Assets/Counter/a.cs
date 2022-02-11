using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class a : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text score;
    [SerializeField] Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        int number = Forever_ShowCount_score.lastScore;
        score.text = "Score : " + number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = "High Score : " + number.ToString();
        }
    }
}
