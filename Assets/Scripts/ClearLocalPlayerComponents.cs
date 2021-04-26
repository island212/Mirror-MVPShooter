using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class ClearLocalPlayerComponents : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (var proxy in GetComponentsInChildren<ClearLocalPlayerComponentsProxy>())
        {
            DestroyComponentsAndProxy(proxy);
        }

        foreach (var proxy in GetComponents<ClearLocalPlayerComponentsProxy>())
        {
            DestroyComponentsAndProxy(proxy);            
        }

        if (!isServer)
        {
            foreach (var comp in GetComponents<IRunOnServer>())
            {
                Destroy(comp as MonoBehaviour);
            }
        }

        if (!isLocalPlayer)
        {
            foreach (var comp in GetComponents<IRunOnLocalClient>())
            {
                Destroy(comp as MonoBehaviour);
            }
        }

        Destroy(this);
    }

    private void DestroyComponentsAndProxy(ClearLocalPlayerComponentsProxy proxy)
    {
        if ((!proxy.onlyServer && !isLocalPlayer) || (proxy.onlyServer && !isServer))
        {
            foreach (var comp in proxy.components)
            {
                Destroy(comp);
            }
        }

        Destroy(proxy);
    }
}

public interface IRunOnServer { }

public interface IRunOnLocalClient { }
