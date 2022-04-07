using UnityEngine;
using UnityEngine.UI;

public class testtest : MonoBehaviour
{
    public Text score;
    public Text HS;
    public int savedHighScore = 0;
    public int curScore = 0;


    void Start()
    {
        curScore = Forever_ShowCount_score.lastScore;
        savedHighScore = PlayerPrefs.GetInt("highScore", 0);
        
        if(curScore > savedHighScore)
        {
            PlayerPrefs.SetInt("highScore", curScore);
        }
        score.text = "Score : " + curScore.ToString();
        HS.text = "High Score : " + savedHighScore.ToString();
    }



}
