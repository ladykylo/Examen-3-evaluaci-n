using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_01 : MonoBehaviour
{
    public Rigidbody rigidBody3D;
    bool direction = true;
    float speed = 10;

    void Update()
    {
        rigidBody3D = gameObject.GetComponent<Rigidbody>();

        if (direction == false)
        {
            rigidBody3D.velocity = Vector2.right * speed;
        }
        else
        {
            rigidBody3D.velocity = Vector2.left * speed;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            if (direction == false)
            {
                direction = true;
            }
            else
            {
                direction = false;
            }

        }

    }
}
