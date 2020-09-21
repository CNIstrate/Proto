using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GrabState_FSM : MonoBehaviour
{
    #region Grabbing Variables
    [SerializeField] public string selectableTag = "Selectable";
    [SerializeField] public float throwForce = 15000f;
    [SerializeField] public Transform grabbedObjLocation;

    public Camera cam;
    public Transform kamera;


    public Transform _selection;
    public GameObject grabbedObj;

    #endregion

    private GrabBaseState currentState;
    public GrabBaseState CurrentState { get; private set; }

    public readonly EmptyHandState EmptyHandState = new EmptyHandState();
    public readonly GrabbingState GrabbingState = new GrabbingState();


    private void Start()
    {
        kamera = cam.GetComponent<Transform>();
        TransitionToState(EmptyHandState);
    }
    void Update()
    {
        currentState.Update(this);

        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<MeshRenderer>();
            selectionRenderer.material.color = Color.white;
            _selection = null;
        }
        Vector3 fwd = kamera.transform.TransformDirection(Vector3.forward);
        var ray = new Ray(kamera.position, fwd.normalized);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<MeshRenderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material.color = Color.green;
                }
                _selection = selection;
            }

        }

    }

    void FixedUpdate()
    {
        currentState.FixedUpdate(this);
    }

    private void OnCollisionEnter(Collision collision) => currentState.OnCollisionEnter(this);

    public void TransitionToState(GrabBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
