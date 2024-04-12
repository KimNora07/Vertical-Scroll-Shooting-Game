using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class App : MonoBehaviour
{
    private string version = "0.1.0";

    private void Awake()
    {
        Object.DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync("01_Title");
        oper.completed += (obj) =>
        {
            TitleMain titleMain = GameObject.FindAnyObjectByType<TitleMain>();
            titleMain.Init(this.version);
        };
    }
}
