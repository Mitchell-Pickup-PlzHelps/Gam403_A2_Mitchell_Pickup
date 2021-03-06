﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 55f, breakSpeed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        float hor = Mathf.Abs(moveHorizontal);
        if (hor < 0.25f)
        {
            Vector3 newVel = new Vector3(0, rb.velocity.y, rb.velocity.z);
            rb.velocity = Vector3.MoveTowards(rb.velocity, newVel, breakSpeed * Time.fixedDeltaTime);
        }
    }
}
