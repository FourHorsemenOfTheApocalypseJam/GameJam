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
    bool checkLeftOrRigth = false;

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
        player.Move(new Vector3(horizontalMove*1, 0, 0.5f)*(speed*Time.deltaTime));

        if (Input.GetAxis("Vertical")>0)
        {
            player.Move(new Vector3(horizontalMove, 0, verticalMove+2) * (speed * Time.deltaTime));
        }        
        if (Input.GetAxis("Horizontal") < 0 && !checkLeftOrRigth)
        {
            Debug.Log("left");
            player.transform.Rotate(0, 0, move * Time.deltaTime);
            player.Move(new Vector3(horizontalMove - 1, 0, verticalMove) * (speed * Time.deltaTime));
        }

        if (Input.GetAxis("Horizontal") > 0 && !checkLeftOrRigth)
        {
            Debug.Log("rigth");
            player.transform.Rotate(0, 0, -move * Time.deltaTime);
            player.Move(new Vector3(horizontalMove +1, 0, verticalMove) * (speed * Time.deltaTime));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collider"))
        {
            checkLeftOrRigth = true;             
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Collider")
        {
            checkLeftOrRigth = false;
        }
    }
}
