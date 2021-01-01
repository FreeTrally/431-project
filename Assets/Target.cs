using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float StoredNumber;  //число относящееся к этой цели
    public Text SlotText;       //текст в слоте инвентаря
    

    //записываем текст в слот инвентаря и скрываем его со сцены
    void Start()
    {
        SlotText.text = StoredNumber.ToString();
        SlotText.gameObject.SetActive(false);
    }
    //если цель отсутствует на сцене (собрана) то включаем отображение текста
    private void Update()
    {
        if(gameObject.activeSelf)
        {
            return;
        }
        else if (!gameObject.activeSelf)
        {
            SlotText.gameObject.SetActive(true);
            Debug.Log("Target Destroyed");
        }
    }
}
