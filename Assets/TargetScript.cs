using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class TargetScript : MonoBehaviour, IPointerDownHandler
{
    public double[] targetVs;
    public Text text;

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;
    int current = 0;

    private void Start()
    {
        text.text = targetVs[current].ToString();
    }

    public void OnPointerDown(PointerEventData data)
    {
        clicked++;
        if (clicked == 1) clicktime = Time.time;

        else if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            this.transform.Rotate(Vector3.forward * -90);
            text.transform.Rotate(Vector3.forward * 90);
            current = (current + 1) % targetVs.Length;
            text.text = targetVs[current].ToString();
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
    }
}
