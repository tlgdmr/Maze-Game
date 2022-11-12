using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerRotation : NetworkBehaviour
{
    [SerializeField] float mouseSensitivity;

    void Update()
    {
        if (!isLocalPlayer) { return; }
        
        PlayerBodyRotation();
    }

    void PlayerBodyRotation()
    {
        float mouseMovementX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseMovementX);
    }
}
