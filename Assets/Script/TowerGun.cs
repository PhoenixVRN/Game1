using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerGun : MonoBehaviour
{
    public float offset;

    public GameObject ammo;
    public Transform shotDir;
    public float speedRotation = 40;

    private float timeShot;
    public float startTime;

   

    void Start()
    {
       
    }

    
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        var a = transform.rotation;
        var b = Quaternion.Euler(0, 0, rotateZ);
        var s = Quaternion.Angle(a, b);
        transform.rotation = Quaternion.Slerp(a, b, (Time.deltaTime * speedRotation) / s);
        //        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Instantiate(ammo, shotDir.position, transform.rotation);
                timeShot = startTime;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}
