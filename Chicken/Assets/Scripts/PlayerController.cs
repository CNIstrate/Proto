using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private PlayerMovement handleMovement;
    [SerializeField] private PlayerShooting handleShooting;
    bool isJumping;
    public bool isOnGround;
    bool isMoving;
    bool moveLeft;
    bool isFalling;
    bool isAttacking;
    bool isCrouching;
    bool canGlide;

    public Animator anim;
    public GameObject egg;

    private void Awake()
    {
        
    }

    private void Start()
    {
        isJumping = false;
        isOnGround = false;
        isMoving = false;
        moveLeft = false;
        isFalling = false;
        isAttacking = false;
        canGlide = false;

        handleShooting.direction = Vector2.left;

    }

    private void Update()
    {

        // Check if on ground
        Debug.DrawRay(transform.position + new Vector3(0f, -1.1f, 0f), Vector3.down * .1f, Color.red);
        Debug.DrawRay(transform.position + new Vector3(.4f, -1.1f, 0f), Vector3.down * .1f, Color.red);
        DetectOnGround();

        // Handle Input
        if (Input.GetButtonDown("Jump"))
        {
            if (isOnGround)
            {
                isJumping = true;
                handleMovement.playerRB.gravityScale = 6f;
            }
        }

        if (handleMovement.playerRB.velocity.y < 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                handleMovement.playerRB.gravityScale = .2f;
                anim.SetBool("Glide", true);
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                handleMovement.playerRB.gravityScale = 9f;
                anim.SetBool("Glide", false);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft = true;
            isMoving = true;
            handleShooting.direction = Vector2.left;

            handleMovement.player.transform.localScale = new Vector2(1, 1);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveLeft = false;
            isMoving = true;
            handleShooting.direction = Vector2.right;
            handleMovement.player.transform.localScale = new Vector2(-1, 1);
        }
        else isMoving = false;

        if(Input.GetKeyDown(KeyCode.Q))
        {
            handleShooting.Shoot();
        }

        // ANimations

        if (isMoving == true)
        {
            anim.SetBool("Move", true);
        }
        else anim.SetBool("Move", false);

        if(Input.GetKeyDown(KeyCode.E))
        {
            GameObject obj = Instantiate(egg, transform.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        // Handle Physics based on Input
        

        if (isJumping == true)
        {
            anim.SetBool("Jump", true);

            handleMovement.Jump();
            isJumping = false;

        }

        if (isMoving == true)
        {
            if (moveLeft == false)
            {
                handleMovement.MoveRight();
            }
            else if (moveLeft == true)
            {
                handleMovement.MoveLeft();
            }
        }
        
        

    }


    void DetectOnGround()
    {
        RaycastHit2D frontLeg = Physics2D.Raycast(transform.position + new Vector3(0f, -1.1f, 0f), Vector3.down, .1f);
        RaycastHit2D backLeg = Physics2D.Raycast(transform.position + new Vector3(.4f, -1.1f, 0f), Vector3.down, .1f);

        if (frontLeg.collider != null && backLeg.collider != null)
        {
            if (frontLeg.collider.tag == "Ground" || backLeg.collider.tag == "Ground")
            {
                isOnGround = true;
                canGlide = false;
                anim.SetBool("Jump", false);
                anim.SetBool("Glide", false);
                handleMovement.playerRB.gravityScale = 6f;
            }
            else
            {

                isOnGround = false;
                canGlide = true;
            }
        }

        
    }

}
