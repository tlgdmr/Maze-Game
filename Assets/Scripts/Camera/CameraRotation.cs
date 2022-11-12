using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraRotation : MonoBehaviour
{
    Camera fpsCamera;

    [SerializeField] float mouseSensitivity;

    private void Start()
    {
        fpsCamera = GetComponentInParent<CameraActivation>().GetCamera();
    }

    private void Update()
    {
        SetCameraRotation();
    }
    void SetCameraRotation()
    {
        float mouseMovementY = Input.GetAxis("Mouse Y");
        float mouseMovementYAxis = Mathf.Clamp(mouseMovementY, -60, 60);

        fpsCamera.transform.localRotation *= Quaternion.Euler(-(mouseMovementYAxis * mouseSensitivity * Time.deltaTime), 0, 0);
    }
}
