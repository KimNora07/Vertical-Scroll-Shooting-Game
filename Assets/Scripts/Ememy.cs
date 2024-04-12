using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ememy : MonoBehaviour
{
    public enum eType
    {
        A, B
    }
    public eType type;

    public int score;
    public Action onExplode;

    public void Explode()
    {
        this.onExplode();
        Destroy(this.gameObject);
    }
}
