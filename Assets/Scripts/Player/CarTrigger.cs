using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particle=null;

    private void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            particle.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            particle.Play();
        }
    }
}
