using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorController : MonoBehaviour
{
    float horizontalMove;
    float verticalMove;
    CharacterController player;
    public float speed;    

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
        //transform.position = transform.position + new Vector3(0,0,1*Time.deltaTime);
        player.Move(new Vector3(horizontalMove * 1, 0, 5) * (3 * Time.deltaTime));

        if (Input.GetAxis("Vertical")>0)
        {
            player.Move(new Vector3(horizontalMove * 1, 0, verticalMove) * (speed * Time.deltaTime));            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 30, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -30, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    
}
