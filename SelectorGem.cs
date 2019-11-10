using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorGem : MonoBehaviour
{
    [SerializeField] GameObject[,] locationArrayGem = new GameObject[3, 2];

    void Start()
    {
        
        locationArrayGem = new GameObject[3, 2]
        {
            { GameObject.Find("SelectorLocation1"),GameObject.Find("SelectorLocation2")},
            { GameObject.Find("SelectorLocation3"),GameObject.Find("SelectorLocation4")},
            { GameObject.Find("SelectorLocation5"),GameObject.Find("SelectorLocation6")}
            
        };
        transform.position = locationArrayGem[0, 0].transform.position;
        //StartCoroutine(WhatTheFuck());
    }

    /*private void Update()
    {
        Debug.Log(locationArrayGem[0, 0]);
        Debug.Log(locationArrayGem[1, 0]);
        Debug.Log(locationArrayGem[2, 0]);
        Debug.Log(locationArrayGem[0, 1]);
        Debug.Log(locationArrayGem[1, 0]);
    }*/

    public void setLocation(int x,int y)
    {
        transform.position = locationArrayGem[x, y].transform.position;
    }

    public IEnumerator WhatTheFuck()
    {
        int k, l;
        k = 0;
        l = 0;
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(1f);
            transform.position = locationArrayGem[k, 0].transform.position;
            k++;
        }
        k = 0;
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(1f);
            transform.position = locationArrayGem[0, l].transform.position;
            l++;
        }
        
    }
}
