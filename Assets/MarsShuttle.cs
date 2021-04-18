using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsShuttle : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = new Vector3(0f, 0f, speed);
    }


}
