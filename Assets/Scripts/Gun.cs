using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Tooltip("if MultiGun Left Fire Point")]
    public Transform firePoint; 
    public GameObject bulletPrefab;

    public virtual void Shoot()
    {
        // 총알 생성
        GameObject go = Instantiate(this.bulletPrefab);
        // 위치 지정
        go.transform.position = this.firePoint.position;
    }
}
