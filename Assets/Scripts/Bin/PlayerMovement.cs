using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;


    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 10f; //serialize so it can be controlled in unity; public can be done alternatively but it will expose these to other scripts
    [SerializeField] private float jumpForce = 20f;



    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
       sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal"); //Raw to stop extra ovement/sliding
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump")) //Button instead key for flexibility is using other buttons
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

       UpdateAnimation(); //added this to make the code cleaner
    }

    private void UpdateAnimation()
    {
         if (dirX > 0f) // For animation, to transition between running and idle
        {
            anim.SetBool("Running", true); //running right
            sprite.flipX = false; //so it doesn't flip when moving right

        }
        else if (dirX < 0f)
        {
            anim.SetBool("Running", true); //running left
            sprite.flipX = true; //to flip the player animation when moving left
        }
        else 
        {
            anim.SetBool("Running", false); //stopped running, now idle
        }

    }
}
