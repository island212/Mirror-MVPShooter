using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeedProvider : NetworkBehaviour, IRunOnServer
{
    public float speed = 20f;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
