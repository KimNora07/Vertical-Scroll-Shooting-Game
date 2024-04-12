using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public GameObject playerBulletPrefab;
    public Gun gun;

    public void Init(Gun gun)
    {
        this.gun = gun;
        this.gun.transform.SetParent(this.transform);
        this.gun.transform.localPosition = Vector3.zero;
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3 (h, v, 0);
        var next = dir.normalized * speed * Time.deltaTime;
        this.transform.position += next;

        // �����̽��ٸ� ������ �� �Ѿ� �߻�
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        // ���� ������ �ִ� ���� �Ѿ��� �߻�
        this.gun.Shoot();
    }
}
