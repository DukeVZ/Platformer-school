using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRender;

    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb; 

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {//make u move left and right
        Move = Input.GetAxis("Horizontal");
        //flips the sprite acordingly
        if (Input.GetKey("d"))
        {
            spriteRender.flipX = false;
        }
        else if (Input.GetKey("a"))
        {
            spriteRender.flipX = true;
        }

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs (Move));
        //you can only jump once (not in the air)
        if (Input.GetButtonDown("Jump") &&  isJumping == false)
        {
            //makes the animations work
            animator.SetBool("isJumping", true);
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //helps with the jump cap (makes it so that the counter goos to 0 when you jump)
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isJumping", false);
            isJumping = false;
        }
    }

    //resets the counter when you make contact with the ground
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
}
