using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class LockCursor : NetworkBehaviour
{
    public override void OnStartServer()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
