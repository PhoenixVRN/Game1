using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    public GameObject dyrka;
    public float hitPointLifeTime;

    public int damage = 1;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //      Debug.Log(hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
          GameObject myHitPoint =  Instantiate(dyrka);
            

            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
