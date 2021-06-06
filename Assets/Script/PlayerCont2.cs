using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont2 : MonoBehaviour
{
    public int speedRotation =100;
    public Vector2 move;
    public int speed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
                if (Input.GetKey(KeyCode.A))
                   transform.Rotate(0,0, speedRotation*Time.deltaTime);

               if (Input.GetKey(KeyCode.D))
                   transform.Rotate(0, 0, -speedRotation * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.left * Time.deltaTime);
    }

 
}
