using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
    

public class PlayerAnimation : NetworkBehaviour
{
    Animator animator;
    PlayerMovement playerMovement;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (!isLocalPlayer) { return; }
        
        RunningAnimation();
        ShootingAnimation();
        Die();
    }

    void RunningAnimation()
    {
        if (playerMovement.GetMovementVector() != new Vector3(0,0,0))
        { 
            animator.SetBool("Running", true); 
        }
        else
        {
            animator.SetBool("Running", false);
        }
    }
    void ShootingAnimation()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            animator.SetBool("Shooting", true); 
        }
        else
        {
            animator.SetBool("Shooting", false);
        }
    }
    void Die()
    {
        if (!Input.GetKey(KeyCode.LeftShift)) { return; }

        animator.SetTrigger("Die");
        
    }
}
