using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed = 3000f;
    public float lifespan = 1.5f;
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Start()
    {
        rigidBody.AddForce(rigidBody.transform.forward * speed);
        Destroy(gameObject, lifespan);
    }
}
