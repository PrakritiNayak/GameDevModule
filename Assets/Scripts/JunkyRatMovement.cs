using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkyRatMovement : MonoBehaviour
{
    private Rigidbody2D rb;
  


    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 10f; //serialize so it can be controlled in unity; public can be done alternatively but it will expose these to other scripts
    [SerializeField] private float jumpForce = 20f;



    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
      
    }


    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal"); //Raw to stop extra ovement/sliding
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump")) //Button instead key for flexibility is using other buttons
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

    }
}
