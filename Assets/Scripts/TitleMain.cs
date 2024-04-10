using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMain : MonoBehaviour
{
    public Text txtVersion;

    private void Awake()
    {
        Debug.Log("TitleMain Awake");    
    }

    public void Init(string version)
    {
        this.txtVersion.text = version;
    }
}
