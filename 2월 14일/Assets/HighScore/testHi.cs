using UnityEngine;
using UnityEngine.UI;

public class testHi : MonoBehaviour
{
    public Text helloWorld;
    public int savedHighScore = 0;

    void Start()
    {
        savedHighScore = PlayerPrefs.GetInt("highScoreHard", 0);
        helloWorld.text = "High Score : " + savedHighScore.ToString();
    }



}
