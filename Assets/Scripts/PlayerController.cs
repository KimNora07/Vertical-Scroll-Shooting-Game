using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public GameObject playerBulletPrefab;

    [SerializeField] private Transform firePoint;

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
        // �Ѿ� ����
        GameObject go = Instantiate(this.playerBulletPrefab);
        // �Ѿ��� �ʱ� ��ġ ����
        //go.transform.position = this.transform.position;
        go.transform.position = this.firePoint.position;

    }
}
