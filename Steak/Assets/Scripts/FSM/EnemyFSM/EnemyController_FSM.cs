using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController_FSM : MonoBehaviour
{
    #region Grabbing Variables
    public GameObject player;
    public int destPoint = 0;
    public Transform[] patrolPoints;
    public NavMeshAgent agent;
    public FieldOfView fowDetect;
    public float shootDelay;
    public Vector3 lastPos;
    [SerializeField] public float agentRotationSpeed;
    [SerializeField] public GameObject bullet;
    [SerializeField] public Transform gun;

    #endregion


    private EnemyBaseFSM currentState;
    public EnemyBaseFSM CurrentState { get; private set; }

    public readonly EnemyIdleState EnemyIdleState = new EnemyIdleState();
    public readonly EnemyPatrolState EnemyPatrolState = new EnemyPatrolState();
    public readonly EnemyChaseState EnemyChaseState = new EnemyChaseState();
    public readonly EnemyScanLastPosState EnemyScanLastPosSate = new EnemyScanLastPosState();

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        TransitionToTstate(EnemyIdleState);
    }
    void Update()
    {
        currentState.Update(this);
    }

    void FixedUpdate()
    {
        currentState.FixedUpdate(this);   
    }

    private void OnCollisionEnter(Collision collision) => currentState.OnCollisionEnter(this);

    public void TransitionToTstate(EnemyBaseFSM state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    public void GotoNextPoint()
    {
        agent.autoBraking = false;

        // Returns if no points have been set up
        if (patrolPoints.Length == 0)
            return;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % patrolPoints.Length;
    }

    public void BulletInstance()
    {
        Instantiate(bullet, gun.transform.position, gun.transform.rotation);
    }


}