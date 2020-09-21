using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{


    public override void EnterState(PlayerController_FSM player)
    {

    }

    public override void FixedUpdate(PlayerController_FSM player)
    {

    }

    public override void OnCollisionEnter(PlayerController_FSM player)
    {

    }

    public override void Update(PlayerController_FSM player)
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            player.TransitionToTstate(player.MovingState);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player.TransitionToTstate(player.JumpingState);
            
        }

        if (Input.GetButtonDown("Sprint"))
        {
            player.TransitionToTstate(new PlayerSprintState());
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            player.speed = player.sprintSpeed;
        }

    }
}


