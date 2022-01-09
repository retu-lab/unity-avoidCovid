using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGhost : MonoBehaviour
{
    Vector3 pos; //������ġ

    float delta = 10.0f; // ��(��)�� �̵������� (x)�ִ밪

    float speed = 1.0f; // �̵��ӵ�

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);

        // �¿� �̵��� �ִ�ġ �� ���� ó���� �̷��� ���ٿ� ���ְ� �ϳ׿�.

        transform.position = v;
    }
}
