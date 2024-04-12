using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
    public GameObject[] gunPrefabs;
    public PlayerController player;
    public Ememy[] enemies;
    public Text txtScore;

    private int totalScore;

    // Awake - Init - Start - Update
    public void Init(GameEnums.eGunType selectedGunType)
    {
        foreach(Ememy enemy in this.enemies)
        {
            enemy.onExplode = () =>
            {
                totalScore += enemy.score;
                this.txtScore.text = totalScore.ToString();
            };
        }
        // 총을 만든다
        Gun gun = this.CreateGun(selectedGunType);
        // 플레이어에게 총을 지급한다
        this.player.Init(gun);
    }

    private Gun CreateGun(GameEnums.eGunType gunType)
    {
        int index = (int)gunType;
        GameObject prefab = this.gunPrefabs[index];
        GameObject go = Instantiate(prefab);
        Gun gun = go.GetComponent<Gun>();
        return gun;
    }
}
