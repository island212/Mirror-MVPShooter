using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManagerDodgeBullet : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);

        Debug.LogFormat("OnServerAddPlayer {0}", conn.identity);
    }

    public override void OnStartClient()
    {
        base.OnStartClient();

        Debug.Log("OnStartClient");
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);

        Debug.Log("OnClientConnect");
    }
}
