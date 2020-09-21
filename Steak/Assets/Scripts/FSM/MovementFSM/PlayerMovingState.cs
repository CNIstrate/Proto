using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingState : PlayerBaseState
{

    public override void EnterState(PlayerController_FSM player)
    {
        
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
        
    }

    public override void Update(PlayerController_FSM player)
    {
        // Detecting the input and setting the desired velocity
        var targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        targetVelocity = player.Rigidbody.transform.TransformDirection(targetVelocity);
        targetVelocity *= player.speed;

        // Apply a force that attempts to reach our target velocity
        var velocity = player.Rigidbody.velocity;
        var velocityChange = (targetVelocity - velocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -player.maxVelocityChange, player.maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -player.maxVelocityChange, player.maxVelocityChange);
        velocityChange.y = 0;
        player.Rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);

        if (!(Input.GetKey(KeyCode.A) || 
             Input.GetKey(KeyCode.S) || 
             Input.GetKey(KeyCode.D) || 
             Input.GetKey(KeyCode.W) ||
             Input.GetButtonDown("Jump")||
             Input.GetButtonDown("Sprint")||
             Input.GetButtonUp("Sprint")
             ))
        {
            player.TransitionToTstate(player.IdleState);
        }


        if (Input.GetButton("Jump"))
        {
            player.TransitionToTstate(player.JumpingState);
        }

        if (Input.GetButtonDown("Sprint"))
        {
            player.TransitionToTstate(new PlayerSprintState());
        }

        else if (Input.GetButtonUp("Sprint"))
        {
            player.speed = player._speed;
            return;
        }
    }

    public override void FixedUpdate(PlayerController_FSM player)
    {
        
    }
}