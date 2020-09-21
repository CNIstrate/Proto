using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region Variables
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float jumpPower = 50f;
    #endregion

    #region References
    [SerializeField] public GameObject player;
    public Rigidbody2D playerRB;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        playerRB.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    public void MoveLeft()
    {
        player.transform.position =(Vector2) player.transform.position + Vector2.left * Time.fixedDeltaTime * movementSpeed;
    }
    public void MoveRight()
    {
        player.transform.position = (Vector2) player.transform.position + Vector2.right * Time.fixedDeltaTime * movementSpeed;
    }



}
