using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GrabBaseState
{
    public abstract void EnterState(GrabState_FSM hand);

    public abstract void Update(GrabState_FSM hand);

    public abstract void FixedUpdate(GrabState_FSM hand);

    public abstract void OnCollisionEnter(GrabState_FSM hand);
}
