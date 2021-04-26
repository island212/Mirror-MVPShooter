using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour, IRunOnLocalClient
{
    public WeaponProvider weapon;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weapon.CmdStartCharging();
        }
    }
}
