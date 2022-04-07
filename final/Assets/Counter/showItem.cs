using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showItem : MonoBehaviour
{
    [SerializeField] int Item = 5;
    [SerializeField] Text ItemText;
    void Start()// 처음에 시행한다
    {
        ItemText.text = Item.ToString();
    }
    void Update()// 계속
    {
        Item = OnUpKeyPress_Throw.throwNum;
        ItemText.text = Item.ToString();
    }
}
