﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takla : MonoBehaviour
{
    new Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bomb"))
        {
            rigidbody.AddForce(new Vector3(0f, 45f, 0f),ForceMode.VelocityChange);
            rigidbody.angularVelocity = new Vector3(10f,0f,0f);
        }
    }
}
