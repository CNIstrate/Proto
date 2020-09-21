using UnityEngine;

public class PlayerController_FSM : MonoBehaviour
{
    #region Player Variables

    public float speed = 10f;
    public float _speed;
    public float sprintSpeed = 18f;
    public float maxVelocityChange = 10.0f;


    // camera and rotation
    [SerializeField] public float lookSensitivity = .5f;
    [SerializeField] public float smoothing = 2f;
    public Vector2 smoothedVelocity;
    public Vector2 curretLookingPos;

    //jumping
    [SerializeField] public float raycastDistance = .3f;
    [SerializeField] public float jumpForce = 6.5f;
    [SerializeField] public float fallMultiplier = 5f;
    [SerializeField] public float lowJumpMultiplier = 5f;

    public bool canRotate;
    #endregion

    public Rigidbody Rigidbody { get; private set; }
    public PlayerBaseState CurrentState { get; private set; }

    public readonly PlayerIdleState IdleState = new PlayerIdleState();
    public readonly PlayerMovingState MovingState = new PlayerMovingState();
    public readonly PlayerJumpingState JumpingState = new PlayerJumpingState();


    private void Awake()
    {
        _speed = speed;
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        canRotate = true;
        TransitionToTstate(IdleState);
    }
    void Update()
    {
        CurrentState.Update(this);
        Rotate();
        
    }

    void FixedUpdate()
    {
        CurrentState.FixedUpdate(this);
        if (Rigidbody.velocity.y < 2)
        {
            Rigidbody.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision) => CurrentState.OnCollisionEnter(this);

    public void TransitionToTstate(PlayerBaseState state)
    {
        CurrentState = state;
        CurrentState.EnterState(this);
    }



    private void Rotate()
    {
        if (!canRotate)
        {
            return;
        }
        else
        {
            Vector2 inputValues = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            inputValues = Vector2.Scale(inputValues, new Vector2(lookSensitivity * smoothing, lookSensitivity * smoothing));

            smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, inputValues.x, 1f / smoothing);
            smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, inputValues.y, 1f / smoothing);

            curretLookingPos += smoothedVelocity;
            curretLookingPos.y = Mathf.Clamp(curretLookingPos.y, -2f, 90f);

            Camera.main.transform.localRotation = Quaternion.AngleAxis(-curretLookingPos.y, Vector3.right);
            transform.localRotation = Quaternion.AngleAxis(curretLookingPos.x, transform.up);
        }
    }

}