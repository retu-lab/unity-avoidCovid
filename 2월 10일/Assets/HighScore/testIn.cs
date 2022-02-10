using UnityEngine;
using UnityEngine.UI;

public class testIn : MonoBehaviour
{
    public Text helloWorld;
    public int savedHighScore = 0;

    void Start()
    {
        savedHighScore = PlayerPrefs.GetInt("highScoreInsane", 0);
        helloWorld.text = "High Score : " + savedHighScore.ToString();
    }



}
