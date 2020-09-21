//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class EnemyMovement : MonoBehaviour
//{
    
//    private void Start()
//    {
//    }

//    private void Update()
//    {
//        if (fowDetect.targetLocated == false)
//        {
//            Patrol();
            
//        }
//        else
//        {
//            Chase();
//        }
//    }

//    void FixedUpdate()
//    {
//        if (!agent.pathPending && agent.remainingDistance < 0.5f)
//            GotoNextPoint();
//    }

//    public void Patrol()
//    {
//        Debug.Log("Target unseen");
//        agent.destination = patrolPoints[destPoint].position;
//        // needs fix for when the agent reaches 0 velocity -> his rotation resets to default.
//        agent.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(agent.desiredVelocity), .05f);
//        agent.transform.eulerAngles = new Vector3(0, agent.transform.eulerAngles.y, 0);
//        agent.stoppingDistance = 0f;

//    }

//    void Chase()
//    {

//        Debug.Log("Target located");
//        agent.destination = player.transform.position;
//        // needs fix for when the agent reaches 0 velocity -> his rotation resets to default.
//        agent.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(agent.desiredVelocity), .05f);
//        agent.transform.eulerAngles = new Vector3(0, agent.transform.eulerAngles.y, 0);
//        agent.stoppingDistance = 5f;
//        if (Time.time > shootDelay)
//        {
//            float fireRate = 0.3f;
//            Instantiate(bullet, gun.transform.position, gun.transform.rotation);
//            shootDelay = Time.time + fireRate;
//        }


//    }
    
//    void Flee()
//    {
//        Debug.Log("Fleeing");
//    }

//    void GotoNextPoint()
//    {
//        agent.autoBraking = false;

//        // Returns if no points have been set up
//        if (patrolPoints.Length == 0)
//            return;

//        // Choose the next point in the array as the destination,
//        // cycling to the start if necessary.
//        destPoint = (destPoint + 1) % patrolPoints.Length;
//    }


    
//}


