using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    float deneme;

    private void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, 6, player.transform.position.z-deneme);
    }
}
