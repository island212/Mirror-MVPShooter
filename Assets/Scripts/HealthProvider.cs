using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthProvider : NetworkBehaviour
{
    public int life = 3;

    public GameObject body;

    /// <summary>
    /// Should only be call on the server
    /// </summary>
    public void OnTriggerDamage(GameObject sender)
    {
        if (isServer)
        {
            NetworkServer.Destroy(sender);

            RpcNotifyDamage();
        }
    }

    [ClientRpc]
    public void RpcNotifyDamage()
    {
        life--;
        if (life <= 0)
        {
            body.SetActive(false);
        }
    }
}
