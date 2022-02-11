using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transiitonTime = 1f;

    //public static string nextSceneIndex;

    void Update()
    {
        /*if (OnMouseDown_SwitchScene.flag == 1)
        {
            LoadNextLevel();
        }*/
    }

    /*public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel((nextSceneIndex)));
    }

    IEnumerator LoadLevel(string levelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transiitonTime);
        //load scene
        SceneManager.LoadScene(levelIndex);
    }*/

}
