using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showItem : MonoBehaviour
{
    [SerializeField] int Item = 5;
    [SerializeField] Text ItemText;
    void Start()// ó���� �����Ѵ�
    {
        ItemText.text = Item.ToString();
    }
    void Update()// ���
    {
        Item = OnUpKeyPress_Throw.throwNum;
        ItemText.text = Item.ToString();
    }
}
