using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;                         // Player's Rigidbody
    Animator pa;                            // Player's Animator
    public float distancePerSecond = 1.5f;  // Movement speed
    public float upwardForce = 1f;          // Force of jump
    bool onGround;                          // If player on ground

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pa = GetComponent<Animator>();
        onGround = false;                   // Not on ground
    }

    // Update is called once per frame
    void Update()
    {
        // Amount to move in each dimension
        float dx = 0;
        float dy = 0;

        // Jump only if on ground
        if (Input.GetKeyDown (KeyCode.UpArrow) && onGround) {
            rb.AddForce(new Vector2(0, upwardForce), ForceMode2D.Impulse);
            // Play jump animation
            pa.SetBool("onGround", false);
        }
        // Move right
        if (Input.GetKey (KeyCode.RightArrow)) {
            dx = distancePerSecond * Time.deltaTime;
            // Play walk animation
            //pa.SetBool("onGround", true);
        }
        // Move by that amount
        rb.position += new Vector2(dx, dy);


    }

    // Is player in contact with ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if object is ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Player is on ground
            onGround = true;
            pa.SetBool("onGround", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // If no longer on ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Player is not on ground
            onGround = false;
        }
    }
}
