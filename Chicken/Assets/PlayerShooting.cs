using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject feather;
    [SerializeField] private Transform featherLaunchPos;

    Rigidbody2D featherRB;
    [SerializeField] private float launchForce;

    public Vector2 direction;

    void Start()
    {

    }

    public void Shoot()
    {   
        GameObject obj = Instantiate(feather, featherLaunchPos.position, featherLaunchPos.rotation);
        obj.GetComponent<Rigidbody2D>().AddForce(direction * launchForce, ForceMode2D.Impulse);
        Destroy(obj, 3f);
    }


}
