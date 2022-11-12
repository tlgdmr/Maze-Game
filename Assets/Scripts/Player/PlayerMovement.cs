using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] float movementSpeed = 3.5f;
    private Vector3 movement;
    private float xAxis;
    private float zAxis;

    public Vector3 GetMovementVector() { return movement; }

    #region Server

    //[Command]
    //private void CmdMove(float xAxis, float zAxis)
    //{
    //    movement = new Vector3(xAxis, 0, zAxis);

    //    transform.Translate(movement.normalized * movementSpeed * Time.deltaTime);
    //}

    #endregion

    #region Client

    [ClientCallback]
    private void Update()
    {
        if (!isLocalPlayer) { return; }

        Movement();
    }

    private void Movement()
    {
         xAxis = Input.GetAxis("Horizontal");
         zAxis = Input.GetAxis("Vertical");

        movement = new Vector3(xAxis, 0, zAxis);

        transform.Translate(movement.normalized * movementSpeed * Time.deltaTime);
    }

    #endregion
}
