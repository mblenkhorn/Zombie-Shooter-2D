﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown2DCharacterController : MonoBehaviour
{

    public float speed = 0.5f;
    new Rigidbody2D rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
        
    }
}
