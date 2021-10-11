using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    float xMove = 0f;
    public float xSpeed = 5f;
    public float jumpForce = 700f;
    bool isGrounded = false;
    bool shouldJump = false;
    Rigidbody2D myRigidbody2D;
    public LayerMask ground;
    public Transform groundCheck;
    bool interacting = false;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
    void FixedUpdate()
    {
        Move();
        CheckJump();
        CheckGround();
    }
    void CheckInput()
    {   
        if(!interacting)
        {
            xMove = Input.GetAxis("Horizontal") * xSpeed;
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                shouldJump = true;
            }
        }
        else
        {
            xMove = 0f;
        }
        
    }
    void CheckJump()
    {
        if (shouldJump)
        {
            Jump();
        }
    }
    void CheckGround()
    {
        Collider2D col = Physics2D.OverlapCircle(groundCheck.position, 1f, ground);
        if (col == null)
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }
    }
    void Jump()
    {
        shouldJump = false;
        myRigidbody2D.AddForce(Vector2.up * jumpForce);
    }
    void Move()
    {
        myRigidbody2D.velocity = new Vector2(xMove, myRigidbody2D.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = collision.transform;
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
        
    }

    public void isInteracting()
    {
        interacting = !interacting;
    }

    
}
