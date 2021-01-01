using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour
{
    public float StoredNumber;

    public abstract void PickTarget();
}
