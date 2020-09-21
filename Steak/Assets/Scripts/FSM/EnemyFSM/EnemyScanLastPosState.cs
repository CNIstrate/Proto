using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScanLastPosState : EnemyBaseFSM
{
    float timeCount;
    public override void EnterState(EnemyController_FSM enemy)
    {
        Debug.Log("Entering Enemy Scan Last Pos State.");
        enemy.agent.destination = enemy.lastPos;
        timeCount = 0f;
    }
    public override void OnCollisionEnter(EnemyController_FSM enemy)
    {
    }
    public override void Update(EnemyController_FSM enemy)
    {
        if(enemy.fowDetect.targetLocated == false)
        {
            return;
        }
        else
        {
            enemy.TransitionToTstate(enemy.EnemyChaseState);
        }
    }
    public override void FixedUpdate(EnemyController_FSM enemy)
    {
        // Enemy going to Patrol state if the player is not in the FOV at the last known position

        if (Vector3.Distance(enemy.agent.transform.position, enemy.lastPos) <= 3f && enemy.fowDetect.targetLocated == false)
        {
            if (timeCount < 3f)
            {
                timeCount += Time.deltaTime;
                return;
            }
            else
            {
                enemy.agent.stoppingDistance = 0f;
                enemy.TransitionToTstate(enemy.EnemyPatrolState);
            }
        }
    }
}
