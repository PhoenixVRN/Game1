using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public GameObject dyrka;

    public float speedRotation = 30;
    public float distanceVisual;
    private Transform _player;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        var direction = _player.position - transform.position;
                var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
 

        if (Vector2.Distance(transform.position, _player.position) < distanceVisual)
        {
            var a = transform.rotation;
            var b = Quaternion.Euler(0, 0, angle);
           var s = Quaternion.Angle(a, b);

            transform.rotation= Quaternion.Slerp(a, b, (Time.deltaTime * speedRotation)/s);
        }
    }

    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(dyrka, gameObject.transform.position, Quaternion.identity);
           
            Die();
        }
    }
   void Die()
    {
        Destroy(gameObject);
    }
}
