using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMain : MonoBehaviour
{
    public Text txtVersion;

    private void Awake()
    {
        Debug.Log("TitleMain Awake");    
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("02_Game");
        }
    }

    public void Init(string version)
    {
        this.txtVersion.text = version;
    }


}
