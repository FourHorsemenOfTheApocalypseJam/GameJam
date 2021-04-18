﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] Vector3 speed = new Vector3(0f, 0f, 10f);
    bool isDispatched = false;
    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Start()
    {
        body.velocity = speed;
    }
    private void Update()
    {
        if (!isDispatched && transform.position.z >= 0f)
        {
            FindObjectOfType<PlayerFollowCamera>().CurrentPlayerState = PlayerState.Falling;
            player.SetActive(true);
            Destroy(gameObject, 10f);
        }
    }
}
