using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 전환에 필요 
using UnityEngine.UI;

// 터치하면 씬을 전환한다 
public class OnMouseDown_SwitchScene : MonoBehaviour
{
    public Animator transition;
    public float transitonTime = 1f;
    public string mainScene;  // 씬 이름：Inspector에 지정
    public string nextSceneIndex;
   // public Image image;
    public static int flag = 0;
    void Start()
    {
        flag = 0;
    }

    void OnMouseDown() 
	{ // 터치하면

 
        OnUpKeyPress_Throw.throwNum = 5;
        OnKeyPress_MoveGravity.badItem = 0;
        OnCollision_SwitchScene.hp = 3;
        OnKeyPress_MoveGravity.jumppower = OnKeyPress_MoveGravity.initateJumpPower;
        OnKeyPress_MoveGravity.speed = OnKeyPress_MoveGravity.initiateSpeed;
        SceneManager.LoadScene (mainScene);
        flag = 1;
        LoadNextLevel();



    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel((nextSceneIndex)));
    }

    IEnumerator LoadLevel(string levelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transitonTime);
        //load scene
        SceneManager.LoadScene(levelIndex);
    }

}
