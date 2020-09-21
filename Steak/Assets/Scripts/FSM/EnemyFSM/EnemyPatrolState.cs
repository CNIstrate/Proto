using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolState : EnemyBaseFSM
{
    public override void EnterState(EnemyController_FSM enemy)
    {
        Debug.Log("Entered Patrol State");
        // needs fix for when the agent reaches 0 velocity -> his rotation resets to default.

        enemy.agent.transform.eulerAngles = new Vector3(0, enemy.transform.eulerAngles.y, 0);
        enemy.agent.stoppingDistance = 0f;
        
    }

    public override void OnCollisionEnter(EnemyController_FSM enemy)
    {
    }

    public override void Update(EnemyController_FSM enemy)
    {
        enemy.agent.destination = enemy.patrolPoints[enemy.destPoint].position;



        if (enemy.fowDetect.targetLocated == false)
        {
            return;

        }
        else if (enemy.fowDetect.targetLocated == true)
        {
            Debug.Log("Exiting Patrol State");

            enemy.TransitionToTstate(enemy.EnemyChaseState);
        }
    }

    public override void FixedUpdate(EnemyController_FSM enemy)
    {
        if (!enemy.agent.pathPending && enemy.agent.remainingDistance < 0.5f)
            enemy.GotoNextPoint();


    }
}
