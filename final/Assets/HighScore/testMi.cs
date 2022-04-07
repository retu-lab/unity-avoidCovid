using UnityEngine;
using UnityEngine.UI;

public class testMi : MonoBehaviour
{
    public Text helloWorld;
    public int savedHighScore = 0;

    void Start()
    {
        savedHighScore = PlayerPrefs.GetInt("highScoreMedium", 0);
        helloWorld.text = "High Score : " + savedHighScore.ToString();
    }



}
