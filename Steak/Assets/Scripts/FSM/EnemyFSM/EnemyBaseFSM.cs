using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBaseFSM
{
    public abstract void EnterState(EnemyController_FSM enemy);

    public abstract void Update(EnemyController_FSM enemy);

    public abstract void FixedUpdate(EnemyController_FSM enemy);

    public abstract void OnCollisionEnter(EnemyController_FSM enemy);
}
