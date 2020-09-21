using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float viewRadius;
    [Range(0,360)]
    public float viewAngle;

    [SerializeField] Transform player;
    public bool targetLocated;

    public void Start()
    {
        targetLocated = false;
    }


    void Update()
    {
        FindVisibleTargets();
        Debug.Log(targetLocated);
    }

    public void FindVisibleTargets()
    {

        Transform target = player.transform;
        Vector3 dirToTarget = (target.position - transform.position).normalized;

        if (Vector3.Angle(transform.forward, dirToTarget) < viewAngle / 2)
        {
            if (Physics.Raycast(transform.position, dirToTarget, out RaycastHit hit, viewRadius))
            {
                if (hit.transform.tag != "Player") { targetLocated = false; Debug.DrawLine(transform.position, target.position, Color.blue); }
                else if (hit.transform.tag == "Player") { targetLocated = true; Debug.DrawLine(transform.position, target.position, Color.red); }
            }
        }

    }

    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if(!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
}
