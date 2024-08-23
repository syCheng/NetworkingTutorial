using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    // Start is called before the first frame update
    void HandleMovement()
    {
        if(isLocalPlayer)
        {
            float horizontal  = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horizontal*0.1f,vertical*0.1f,0);
            transform.position = transform.position + movement;
        }        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();


        if(isLocalPlayer)
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("Sending hola to server!");
                Hola();
            }
        }

       
    }


    [Command]
    void Hola()
    {
        Debug.Log("Received hola from the client!");
        ReplyHola();
    }

    [TargetRpc]
    void ReplyHola()
    {
        Debug.Log("Received hola from server!");        
    }

    [ClientRpc]
    void TooHigh()
    {
        Debug.Log("Too high!");
    }




}
