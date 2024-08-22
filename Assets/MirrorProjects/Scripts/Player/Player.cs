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
    }
}
