using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyBaseFSM
{


    public override void EnterState(EnemyController_FSM enemy)
    {
        enemy.TransitionToTstate(enemy.EnemyPatrolState);
    }

    public override void OnCollisionEnter(EnemyController_FSM enemy)
    {
    }

    public override void Update(EnemyController_FSM enemy)
    {
        
    }


    public override void FixedUpdate(EnemyController_FSM enemy)
    {


    }



}