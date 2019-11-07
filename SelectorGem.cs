using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorGem : MonoBehaviour
{
    [SerializeField] private Transform thisGameObject;
    //Transforms for the selector
    [SerializeField] private Transform[] selectorLocation;

    void Start()
    {
        thisGameObject = selectorLocation[0];

    }

    public void setLocation(int i)
    {
        switch (i)
        {
            case 0:
                thisGameObject = selectorLocation[i];

                break;
            case 1:
                thisGameObject = selectorLocation[i];

                break;
            case 2:
                thisGameObject = selectorLocation[i];

                break;
            case 3:
                thisGameObject = selectorLocation[i];

                break;
            case 4:
                thisGameObject = selectorLocation[i];

                break;
            case 5:
                thisGameObject = selectorLocation[i];
                
                break;


        }
    }
}
