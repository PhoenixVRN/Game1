using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public float destroyTime;
    
    //    public GameObject dyrka;
    public float hitPointLifeTime;

    public int damage = 5;
    void Start()
    {
        rb.velocity = transform.right * speed;
        Invoke("DestroyAmmo", destroyTime);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
              Debug.Log(hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
 //         Instantiate(dyrka, gameObject.transform.position, Quaternion.identity);
            

            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    void DestroyAmmo()
    {
        Destroy(gameObject);
    }
}
