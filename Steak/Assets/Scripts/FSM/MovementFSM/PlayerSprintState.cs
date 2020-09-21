using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprintState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSM player)
    {
        player.speed = player.sprintSpeed;
    }

    public override void FixedUpdate(PlayerController_FSM player)
    {
    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {
    }

    public override void Update(PlayerController_FSM player)
    {
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

        if (Input.GetButtonUp("Sprint"))
        {
            player.speed = player._speed;
            player.TransitionToTstate(player.IdleState);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player.TransitionToTstate(player.JumpingState);
        }
    }
}
