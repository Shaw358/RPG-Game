using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SelectorGem selectorGem;

    //buttons
    [SerializeField] TextMeshPro[,] buttonArray = new TextMeshPro[3, 2];
    [SerializeField] Transform[,] locationArray = new Transform[3, 2];

    Vector2 diamondVector;

    [SerializeField] private int x, y;


    //General game stats
    [SerializeField] private GameObject[] inventory;
    [SerializeField] private GameObject[] charactersSelected;
    [SerializeField] private int gold;
    [SerializeField] private int exp;


    #region FirstCharacterStats

    [SerializeField] private int c1Level;
    [SerializeField] private int character1Exp;
    [SerializeField] private bool c1DoesFireDamage;
    [SerializeField] private bool c1DoesPoisonDamage;

    #endregion

    #region SecondCharacterStats

    [SerializeField] private int c2Level;
    [SerializeField] private int character2Exp;
    [SerializeField] private bool c2DoesFireDamage;
    [SerializeField] private bool c2DoesPoisonDamage;

    #endregion

    #region ThirdCharacterStats

    [SerializeField] private int c3Level;
    [SerializeField] private int character3Exp;
    [SerializeField] private bool c3DoesFireDamage;
    [SerializeField] private bool c3DoesPoisonDamage;

    #endregion

    #region characterScript

    [SerializeField] private bool battleStarts;
    [SerializeField] private Transform[] characterPosition;

    //main character scripts
    [SerializeField] private c1Script scriptC1;
    [SerializeField] private MainCharacter mainCharacter;

    //Secondary character scripts
    [SerializeField] private c2Script scriptC2;

    //tertiary character scripts
    [SerializeField] private c3Script scriptC3;

    #endregion

    //Selected enemy to attack
    private GameObject enemySelected;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        mainCharacter = GameObject.Find("Adventurer").GetComponent<MainCharacter>();

        gold = 10;
        c1Level = 1;
        c2Level = 1;
        c3Level = 1;
    }

    private void Start()
    {
        x = 0;
        y = 0;
        buttonArray = new TextMeshPro[3, 2]
        { 
            { GameObject.Find("Button1").GetComponent<TextMeshPro>(),GameObject.Find("Button4").GetComponent<TextMeshPro>()},
            { GameObject.Find("Button2").GetComponent<TextMeshPro>(),GameObject.Find("Button5").GetComponent<TextMeshPro>()},
            { GameObject.Find("Button3").GetComponent<TextMeshPro>(),GameObject.Find("Button6").GetComponent<TextMeshPro>()}
        };

        /*locationArray = new Transform[3, 2]
        {
            { GameObject.Find("SelectorLocation1").GetComponent<Transform>(), GameObject.Find("SelectorLocation4").GetComponent<Transform>()},
            { GameObject.Find("SelectorLocation2").GetComponent<Transform>(), GameObject.Find("SelectorLocation5").GetComponent<Transform>()},
            { GameObject.Find("SelectorLocation3").GetComponent<Transform>(), GameObject.Find("SelectorLocation6").GetComponent<Transform>()},
        };
        */

        /*StartCoroutine(mainCharacter.AnimatorTester());
        textPro[0].text = "Attack";
        textPro[1].text = "Magic";
        textPro[2].text = "Flee";
        textPro[3].text = "Inventory";
        textPro[4].text = "";
        textPro[5].text = "";
        */
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(diamondVector.y +1 < buttonArray.GetLength(1)) // pakt y as van md array
            {
                selectorGem.setLocation(x, y);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (diamondVector.y - 1 < buttonArray.GetLength(1)) // pakt y as van md array
            {
                selectorGem.setLocation(x, y);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (diamondVector.x + 1 < buttonArray.GetLength(0)) // pakt x as van md array
            {
                selectorGem.setLocation(x, y);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (diamondVector.x - 1 < buttonArray.GetLength(0)) // pakt x as van md array
            {
                selectorGem.setLocation(x, y);
            }
        }
    }

    #region battleMenu / Interface








    #endregion


    private void BattleStarts()
    {
        int currentCharacter = 0;
        int currentCharacterPosition = 0;
        for (int i = 0; i < charactersSelected.Length; i++)
        {
            Instantiate(charactersSelected[currentCharacter], characterPosition[currentCharacterPosition].position, characterPosition[currentCharacterPosition].rotation);
            currentCharacter++;
            currentCharacterPosition++;
        }
    }

    public void EnemySlain(int goldEarned, int expEarned)
    {
        gold += goldEarned;
        exp += expEarned;
    }
}
 
