using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;

    bool isJumpInput = false;
    bool isGrounded = true;

    // Start is called before the first frame update

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJumpInput = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumpInput)
        {
            if (isGrounded)
            {
                playerRB.AddForce(Vector2.up * 400f);
                isJumpInput = false;
            }
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRB.AddForce(Vector2.right * 1000f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRB.AddForce(Vector2.left * 1000f * Time.deltaTime);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
