using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorGem : MonoBehaviour
{
    [SerializeField] private Transform thisGameObject;
    //Transforms for the selector
    [SerializeField] Transform[,] locationArrayGem = new Transform[3, 2];

    void Start()
    {
        locationArrayGem = new Transform[3, 2]
        {
            { GameObject.Find("SelectorLocation1").GetComponent<Transform>(),GameObject.Find("SelectorLocation4").GetComponent<Transform>() },
            { GameObject.Find("SelectorLocation2").GetComponent<Transform>(),GameObject.Find("SelectorLocation5").GetComponent<Transform>() },
            { GameObject.Find("SelectorLocation3").GetComponent<Transform>(),GameObject.Find("SelectorLocation6").GetComponent<Transform>() },
        };
        thisGameObject = locationArrayGem[0, 0];
    }

    public void setLocation(int x,int y)
    {
        thisGameObject = locationArrayGem[x, y];
    }
}
