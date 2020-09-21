using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyHandState : GrabBaseState
{
    public override void EnterState(GrabState_FSM hand)
    {

    }

    public override void FixedUpdate(GrabState_FSM hand)
    {

    }

    public override void OnCollisionEnter(GrabState_FSM hand)
    {
    }

    public override void Update(GrabState_FSM hand)
    {

        if (hand._selection != null)
        {
            hand.TransitionToState(hand.GrabbingState);
        }


    }
}
