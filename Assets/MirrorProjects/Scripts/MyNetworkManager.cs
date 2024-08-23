using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        //base.OnStartServer();
        Debug.Log("Server Staarted!");
    }



    public override void OnStopServer()
    {
        //base.OnStopServer();
        Debug.Log("Server stopped!");
    }


    public override void OnClientConnect()
    {
        //base.OnClientConnect();
        Debug.Log("Connected to server!");
    }

    public override void OnClientDisconnect()
    {
        //base.OnClientDisconnect();
        Debug.Log("Disconnected from server!");
    }


}
