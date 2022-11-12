using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraActivation : NetworkBehaviour
{
    [SerializeField] Camera fpsCamera;

    public Camera GetCamera() { return fpsCamera; }

    public override void OnStartAuthority()
    {
        fpsCamera.enabled = true;
    }
}
