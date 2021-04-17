using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyFall : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] float maxVertSpeed = -10f;
    [SerializeField] float gravity = -10f;
    [SerializeField] float xSpeed = 5f;
    [SerializeField] float zSpeed = 5f;
    float xInput = 0f;
    float yInput = 0f;
    float horizontalAcceleration = 10f;
    float minAcceptableVelocity = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        FallSpeedControl();
        PlayerFallMovement();
    }

    private void FallSpeedControl()
    {
        if (body.velocity.y < maxVertSpeed)
        {
            body.AddForce(new Vector3(0f,-gravity/10f,0f), ForceMode.Acceleration);
        }
        if (body.velocity.y > 0.95f * maxVertSpeed)
        {
            body.AddForce(new Vector3(0f,gravity,0f), ForceMode.Acceleration);
        }
    }

    private void PlayerFallMovement()
    {
        if (Mathf.Abs(xInput) >= 0.1f)
        {
            if (Mathf.Abs(body.velocity.x) < Mathf.Abs(xSpeed))
            {
                body.AddForce(new Vector3(xInput * horizontalAcceleration, 0f, 0f), ForceMode.Acceleration);
            }
            else
            {
                if (body.velocity.x >= 0)
                {
                    body.AddForce(new Vector3(-horizontalAcceleration / 10f, 0f, 0f), ForceMode.Acceleration);
                }
                else
                {
                    body.AddForce(new Vector3(horizontalAcceleration / 10f, 0f, 0f), ForceMode.Acceleration);

                }
            }
        }
        else
        {
            if (body.velocity.x > minAcceptableVelocity)
            {
                body.AddForce(new Vector3(-horizontalAcceleration /*/ 10f*/, 0f, 0f), ForceMode.Acceleration);
            }
            else if(body.velocity.x < minAcceptableVelocity)
            {
                body.AddForce(new Vector3(horizontalAcceleration /*/ 10f*/, 0f, 0f), ForceMode.Acceleration);
            }
        }
        if (Mathf.Abs(yInput) >= 0.1f)
        {
            if (Mathf.Abs(body.velocity.z) < Mathf.Abs(zSpeed))
            {
                body.AddForce(new Vector3(0f,0f,yInput* horizontalAcceleration), ForceMode.Acceleration);
            }
            else
            {
                if (body.velocity.z >= 0)
                {
                    body.AddForce(new Vector3(0f,0f,- horizontalAcceleration / 10f), ForceMode.Acceleration);
                }
                else
                {
                    body.AddForce(new Vector3(0f,0f, horizontalAcceleration / 10f), ForceMode.Acceleration);

                }
            }
        }
        else
        {
            if (body.velocity.z > minAcceptableVelocity)
            {
                body.AddForce(new Vector3(0f /*/ 10f*/, 0f, -horizontalAcceleration), ForceMode.Acceleration);
            }
            else
            {
                body.AddForce(new Vector3(0f /*/ 10f*/, 0f, horizontalAcceleration), ForceMode.Acceleration);
            }
        }
    }
}
