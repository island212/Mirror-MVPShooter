using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour, IRunOnLocalClient
{
    public PlayerMovementProvider provider;

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        float rotation = 0;
        if (Input.GetKey(KeyCode.Q))
        {
            rotation -= 1;
        }

        if (Input.GetKey(KeyCode.E))
        {
            rotation += 1;
        }

        if(input != Vector2.zero || rotation != 0)
            provider.CmdMove(input, rotation);
    }
}
