using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : EnemyBaseFSM
{
    Vector3 moveDirection, fleeDirection;
    bool canShoot;
    
    public override void EnterState(EnemyController_FSM enemy)
    {
        Debug.Log("Entering Chase State");
        canShoot = true;   
    }

    public override void Update(EnemyController_FSM enemy)
    {
        // Enemy saving the player's last known position
        if (enemy.fowDetect.targetLocated == true)
        {
            enemy.lastPos = enemy.player.transform.position;
        }
        
        // Enemy stopping at 5 units distance when close to the player
        else if(Vector3.Distance(enemy.agent.transform.position, enemy.player.transform.position) <= 3f && enemy.fowDetect.targetLocated == true)
        {
            enemy.agent.stoppingDistance = 5f;
        }
    }
    public override void FixedUpdate(EnemyController_FSM enemy)
    {
        // Enemy scouts last know player position
        if (enemy.fowDetect.targetLocated == false)
        {
            enemy.TransitionToTstate(enemy.EnemyScanLastPosSate);
        }
        else
        {
            // Enemy movement when the user is located
            moveDirection = (enemy.agent.destination - enemy.agent.transform.position).normalized;
            fleeDirection = (enemy.agent.transform.position - enemy.player.transform.position).normalized;

            // Handling the rotation
            enemy.agent.destination = enemy.player.transform.position;
            Quaternion rotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            enemy.agent.transform.rotation = rotation;

            // Enemy shooting when player is located | small code - didn't think it was worth separating it to another state.
            if (canShoot == true)
            {
                if (Time.time > enemy.shootDelay)
                {
                    float fireRate = 0.1f;
                    enemy.BulletInstance();
                    enemy.shootDelay = Time.time + fireRate;
                }
            }
        }
    }

    public override void OnCollisionEnter(EnemyController_FSM enemy)
    {
    }
}
