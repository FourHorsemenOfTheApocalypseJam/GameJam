using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorController : MonoBehaviour
{
    public float horizontalMove;
    float verticalMove;
    CharacterController player;
    public float speed;
    public float move;
    public float wheelRotateSpeed;

    public GameObject solOn;
    public GameObject sagOn;
    public GameObject solArka;
    public GameObject sagArka;

    private void Start()
    {
        player = GetComponent<CharacterController>();        
    }
    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");      
        
    }
    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontalMove*1, 0, .1f)*(speed*Time.deltaTime));
        solOn.transform.Rotate(wheelRotateSpeed, 0, 0);
        solArka.transform.Rotate(wheelRotateSpeed, 0, 0);
        sagArka.transform.Rotate(wheelRotateSpeed, 0, 0);
        sagOn.transform.Rotate(wheelRotateSpeed, 0, 0);

        if (Input.GetAxis("Vertical")>0)
        {
            player.Move(new Vector3(horizontalMove, 0, verticalMove+1) * (speed * Time.deltaTime));
            solOn.transform.Rotate(wheelRotateSpeed+2, 0, 0);
            solArka.transform.Rotate(wheelRotateSpeed+2, 0, 0);
            sagArka.transform.Rotate(wheelRotateSpeed+2, 0, 0);
            sagOn.transform.Rotate(wheelRotateSpeed+2, 0, 0);
        }     
    }
    
}
