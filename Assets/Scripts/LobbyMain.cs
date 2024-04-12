using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyMain : MonoBehaviour
{
    
    public Button btnStart;
    public Button btnSingleGun;
    public Button btnMultiGun;
    public Text txtSelectedGun;
    private GameEnums.eGunType selectedGunType;

    public GameEnums.eGunType SelectedGunType
    {
        set
        {
            this.selectedGunType = value;
            this.txtSelectedGun.text = string.Format("{0}을 선택하셨습니다", this.selectedGunType);
        }
    }

    private void Start()
    {
        this.SelectedGunType = GameEnums.eGunType.Single;

        this.btnStart.onClick.AddListener(delegate 
        { 
            Debug.Log("게임 시작");

            // 선택된 건의 타입 출력
            Debug.Log(this.selectedGunType);
            AsyncOperation oper = SceneManager.LoadSceneAsync("03_Game");
            oper.completed += (obj) =>
            {
                GameMain gameMain = GameObject.FindObjectOfType<GameMain>();
                gameMain.Init(this.selectedGunType);
            };
        });
        this.btnSingleGun.onClick.AddListener(delegate
        {
            Debug.Log("싱글건 선택");
            this.SelectedGunType = GameEnums.eGunType.Single;
        });
        this.btnMultiGun.onClick.AddListener(delegate
        {
            Debug.Log("멀티건 선택");
            this.SelectedGunType = GameEnums.eGunType.Multiple;
        });
    }
}
