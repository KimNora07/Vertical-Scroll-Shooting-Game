using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiGun : Gun
{
    [Tooltip("Right Fire Point")]
    public Transform firePoint2; // Right

    public override void Shoot()
    {
        // 총알 생성
        GameObject go = Instantiate(this.bulletPrefab); // left
        GameObject go2 = Instantiate(this.bulletPrefab); // right
        // 위치 지정
        go.transform.position = this.firePoint.position; // left
        go2.transform.position = this.firePoint2.position; // right
    }
}
