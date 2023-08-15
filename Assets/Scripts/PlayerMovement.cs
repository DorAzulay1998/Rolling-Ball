using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed;
    Rigidbody rb;
    float timer;
    void Start()
    {
        timer = 0;

        moveSpeed = 15f;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        Jump();
    }

    void FixedUpdate() 
    {
        if(TextScript.instance.finishLine == false)
        {
            Movement();
        }
    }

    void Movement()
    {
        float horiPos = Input.GetAxis("Horizontal");
        float vertPos = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(-horiPos, 0, -vertPos);
        rb.AddForce(movement * moveSpeed);
    }

    void Jump()
    {
        if (TextScript.instance.finishLine == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && timer > 1.5f)
            {
                rb.AddForce(Vector3.up * 300);
                timer = 0;
            }
        }
    }
}
