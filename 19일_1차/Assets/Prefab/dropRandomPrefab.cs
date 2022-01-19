using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropRandomPrefab : MonoBehaviour
{
    public GameObject[] itemPrefab;
    public float intervalSec = 3;
    [SerializeField] float ran = 0;

    void Start()
    {
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    void CreatePrefab()
    {
        ran += Time.deltaTime;
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;

        ran *= 10;
        int itemIndex = ((int)ran % itemPrefab.Length);
        GameObject newGameObject = Instantiate(itemPrefab[itemIndex]) as GameObject;
        newGameObject.transform.position = newPos;
    }

}
