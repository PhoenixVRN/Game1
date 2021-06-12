using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    private float timeShot;
    public float startTime;

    void FixedUpdate()
    {
        if (timeShot <= 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                timeShot = startTime;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
