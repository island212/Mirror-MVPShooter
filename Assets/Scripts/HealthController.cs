using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour, IRunOnServer
{
    public HealthProvider healthProvider;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damageable")
        {
            healthProvider.OnTriggerDamage(collision.gameObject);
        }
    }
}
