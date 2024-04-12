using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiGun : Gun
{
    [Tooltip("Right Fire Point")]
    public Transform firePoint2; // Right

    public override void Shoot()
    {
        // �Ѿ� ����
        GameObject go = Instantiate(this.bulletPrefab); // left
        GameObject go2 = Instantiate(this.bulletPrefab); // right
        // ��ġ ����
        go.transform.position = this.firePoint.position; // left
        go2.transform.position = this.firePoint2.position; // right
    }
}
