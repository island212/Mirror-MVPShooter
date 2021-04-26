using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponProvider : NetworkBehaviour
{
    public float speed = 15f;
    public float life = 3f;
    public float cooldown = 1f;

    public float minChargeScale = 0.3f, maxChargeScale = 1f;
    public float maxChargeTime = 1f;

    public GameObject bulletPrefab;
    public Transform firePosition;

    private float cooldownTime;

    [Command]
    public void CmdStartCharging()
    {
        if (Time.time > cooldownTime)
        {
            cooldownTime = Time.time + cooldown;
            RpcStartCharging();
        }
    }

    [ClientRpc]
    private void RpcStartCharging()
    {
        var bullet = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation);
        bullet.AddComponent<BulletSpeedProvider>();
        Destroy(bullet, life);
    }
}
