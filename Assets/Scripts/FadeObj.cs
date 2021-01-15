using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeObj : MonoBehaviour
{
    private bool fadeOut, fadeIn;
    public float fadeSpeed;

    void Start()
    {

    }

    void Update()
    {
        if (fadeIn)
        {
            var objCol = this.GetComponent<Renderer>().material.color;
            var fadeAm = objCol.a + (fadeSpeed * Time.deltaTime);

            objCol = new Color(objCol.r, objCol.g, objCol.b, fadeAm);
            this.GetComponent<Renderer>().material.color = objCol;

            if (objCol.a >= 1)
                fadeIn = false;
        }

        if (fadeOut)
        {
            var objCol = this.GetComponent<Renderer>().material.color;
            var fadeAm = objCol.a - (fadeSpeed * Time.deltaTime);

            objCol = new Color(objCol.r, objCol.g, objCol.b, fadeAm);
            this.GetComponent<Renderer>().material.color = objCol;

            if (objCol.a <= 0)
                fadeOut = false;
        }
    }

    private void OnEnable()
    {
        FadeInObj();
    }

    public void FadeOutObj()
    {
        fadeOut = true;
    }

    public void FadeInObj()
    {
        fadeIn = true;
    }
}
