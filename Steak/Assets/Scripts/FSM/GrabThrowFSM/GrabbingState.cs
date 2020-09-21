using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingState : GrabBaseState
{
    bool isThrow;
    bool isDrop;

    public override void EnterState(GrabState_FSM hand)
    {
        Debug.Log("Entering Grabbing State");
    }

    public override void FixedUpdate(GrabState_FSM hand)
    {
        Vector3 fwd = hand.kamera.transform.TransformDirection(Vector3.forward);

        if (isDrop == true)
        {
            var grabbedObject = hand.grabbedObj.GetComponent<Rigidbody>();
            grabbedObject.transform.parent = null;
            Physics.IgnoreLayerCollision(9, 10, false);
            hand.grabbedObj = null;
            hand.TransitionToState(hand.EmptyHandState);
            isDrop = false;
        }

        if (hand.grabbedObj)
        {
            var grabbedObject = hand.grabbedObj.GetComponent<Rigidbody>();
            var desiredVelocity = 10 * (hand.grabbedObjLocation.position - hand.grabbedObj.transform.position);
            grabbedObject.velocity = Vector3.Lerp(desiredVelocity, Vector3.zero, .4f);
            grabbedObject.transform.parent = hand.kamera;
            Physics.IgnoreLayerCollision(9, 10, true);


            if (isThrow == true)
            {
                Physics.IgnoreLayerCollision(9, 10, false);
                grabbedObject.AddForce(fwd.normalized * hand.throwForce * grabbedObject.mass / 10);
                grabbedObject.GetComponent<Rigidbody>().transform.parent = null;
                hand.grabbedObj = null;
                hand.TransitionToState(hand.EmptyHandState);
                isThrow = false;
            }
        }
    }

    public override void OnCollisionEnter(GrabState_FSM hand)
    {
    }

    public override void Update(GrabState_FSM hand)
    {

        Vector3 fwd = hand.kamera.transform.TransformDirection(Vector3.forward);
        var ray = new Ray(hand.kamera.position, fwd.normalized);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out RaycastHit hitPickup) && hitPickup.transform.GetComponent<Rigidbody>() && hitPickup.transform.CompareTag(hand.selectableTag))
        {

            if (hand.grabbedObj == null)
            {
                hand.grabbedObj = hitPickup.transform.gameObject;
            }
            else
            {
                hand.TransitionToState(hand.EmptyHandState);

            }
        }

        if (Input.GetKeyDown(KeyCode.T) && hand.grabbedObj != null)
        {
            isDrop = true;

        }

        if (Input.GetMouseButtonDown(1))
        {
            isThrow = true;
        }
    }
}
   
