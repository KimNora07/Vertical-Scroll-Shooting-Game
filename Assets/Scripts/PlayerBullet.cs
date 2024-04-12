using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Vector3 next = new Vector3(0, 1 * speed * Time.deltaTime, 0);
        this.transform.position += next;

        // 카메라를 벗어 났을 때 제거
        if(this.transform.position.y >= 5.73f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ememy enemy = collision.gameObject.GetComponent<Ememy>();
        if (enemy != null)
        {
            Debug.Log(enemy.type);
            this.Explode();
            enemy.Explode();
        }
    }

    private void Explode()
    {
        Destroy(this.gameObject);
    }
}
