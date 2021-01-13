using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    //четыре значения хранящиеся в цели и ГО для кусочка пазла
    public double NumberOne;  
    public double NumberTwo;
    public double NumberThree;
    public double NumberFour;
    public GameObject PuzzlePiece;

    private double[] PuzzleArray;

    //копируем значения цели в кусочек пазла
    void Start()
    {
        PuzzleArray = new double[] { NumberOne, NumberTwo, NumberThree, NumberFour};
        System.Array.Copy(PuzzleArray, PuzzlePiece.GetComponent<TargetScript>().targetVs, PuzzleArray.Length);
    }
    private void Update()
    {
        if(gameObject.activeSelf)
        {
            return;
        }
        else if (!gameObject.activeSelf)
        {
            PuzzlePiece.SetActive(true);
            Debug.Log("Target Destroyed");
        }
    }
}
