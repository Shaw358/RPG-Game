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
            { GameObject.Find("SelectorLocation1"),GameObject.Find("SelectorLocation4")},
            { GameObject.Find("SelectorLocation2"),GameObject.Find("SelectorLocation5")},
            { GameObject.Find("SelectorLocation3"),GameObject.Find("SelectorLocation6")}
            
        };
        transform.position = locationArrayGem[0, 0].transform.position;
    }

    public void setLocation(int x,int y)
    {
        transform.position = locationArrayGem[x, y].transform.position;
    }
}
