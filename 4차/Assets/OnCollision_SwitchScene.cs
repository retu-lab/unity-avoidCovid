using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnCollision_SwitchScene : MonoBehaviour
{
    
    public string targetObjectName;
    public string sceneName;
    public static int hp = 3;

    /*void OnCollisionEnter2D(Collision2D collision) //�浹���� ��
    {
        if(collision.gameObject.name == targetObjectName)
        {
            //hp--;
        }
        //���� �浹�� ���� �̸��� ��ǥ ������Ʈ���ٸ�
        if (collision.gameObject.name == targetObjectName && hp <= 0)
        {
            //���� ��ȯ�Ѵ�
            SceneManager.LoadScene(sceneName);
        }
    }*/

    void Update()
    {

        if (hp <= 0)
            SceneManager.LoadScene(sceneName);
    }

}
