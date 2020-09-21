using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject)
        {
            collision.gameObject.transform.position = new Vector3(0, 3, 0);
        }
    }
}
