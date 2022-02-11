using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour
{
    public Text helloWorld;
    public int savedHighScore = 0;

    void Start()
    {
        savedHighScore = PlayerPrefs.GetInt("highScore", 0);
        helloWorld.text = "High Score : " + savedHighScore.ToString();
    }



}
