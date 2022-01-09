using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnCollision_SwitchScene : MonoBehaviour
{
    
    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision) //�浹���� ��
    {
        //���� �浹�� ���� �̸��� ��ǥ ������Ʈ���ٸ�
        if (collision.gameObject.name == targetObjectName)
        {
            //���� ��ȯ�Ѵ�
            SceneManager.LoadScene(sceneName);
        }
    }
}
