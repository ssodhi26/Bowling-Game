﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule2 : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // rb.isKinematic = false;
        rb.detectCollisions = true;
    }
}
