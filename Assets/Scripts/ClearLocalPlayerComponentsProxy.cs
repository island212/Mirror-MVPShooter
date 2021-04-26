using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLocalPlayerComponentsProxy : MonoBehaviour
{
    public Behaviour[] components;

    public bool onlyServer;

    void Start()
    {
        Debug.LogWarning("The ClearLocalPlayerComponentsProxy wasn't destroy. You need to have a ClearLocalPlayerComponents at the root of the GameObject");
    }
}
