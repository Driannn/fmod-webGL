using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3( speed, rb.velocity.y, 0f );
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3((speed * -1), rb.velocity.y, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0f);
        }
        
    }
}
