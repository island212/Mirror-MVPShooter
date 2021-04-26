using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementProvider : NetworkBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 200f;

    public Transform head;

    [Command]
    public void CmdMove(Vector2 moveInput, float rotationInput)
    {
        float deltaSpeed = speed * Time.deltaTime;
        transform.position += head.forward * moveInput.y * deltaSpeed + head.right * moveInput.x * deltaSpeed;

        transform.Rotate(0, rotationInput * rotateSpeed * Time.deltaTime, 0);
    }
}
