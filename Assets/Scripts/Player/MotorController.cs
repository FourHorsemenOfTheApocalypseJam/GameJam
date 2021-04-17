using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorController : MonoBehaviour
{
    float horizontalMove;
    float verticalMove;
    CharacterController playerController;
    public float speed;
    public float move;

    private void Start()
    {
        playerController = GetComponent<CharacterController>();        
    }
    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        playerController.transform.Rotate(0, 0, 0);
       
        
    }
    private void FixedUpdate()
    {
        playerController.Move(new Vector3(horizontalMove*1, 0, verticalMove)*(speed*Time.deltaTime));

        if (Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("sol");
            playerController.transform.Rotate(0, 0, move * Time.deltaTime);            
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("sağ");
            playerController.transform.Rotate(0, 0, -move * Time.deltaTime);
        }
    }
}
