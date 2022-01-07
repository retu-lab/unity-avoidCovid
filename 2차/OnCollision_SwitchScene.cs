using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnCollision_SwitchScene : MonoBehaviour
{
    
    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision) //충돌했을 때
    {
        //만약 충돌한 것의 이름이 목표 오브젝트였다면
        if (collision.gameObject.name == targetObjectName)
        {
            //씬을 전환한다
            SceneManager.LoadScene(sceneName);
        }
    }
}
