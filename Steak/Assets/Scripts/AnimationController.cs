using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public PlayerController_FSM player;

    // Start is called before the first frame update
    void Awake()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        if(Input.GetKey(KeyCode.S))
        {
            animator.SetBool("walkingBackwards", true);
        }
        else
        {
            animator.SetBool("walkingBackwards", false);

        }

        if (Input.GetButton("Jump"))
        {
            animator.SetBool("jumping", true);

        }
        else
        {
            animator.SetBool("jumping", false);
        }

        if (Input.GetButtonDown("Sprint"))
        {
            animator.SetBool("sprinting", true);
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            animator.SetBool("sprinting", false);
        }



    }
}
