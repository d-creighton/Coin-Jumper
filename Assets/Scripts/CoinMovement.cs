using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    Rigidbody2D rb;                     // Object's Rigidbody
    public float movementSpeed = 0.5f;  // Object's speed

    // Start is called before the first frame update
    void Start()
    {
        // Get object's Rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Increment position by movementSpeed in negative x direction,
        // 0 in y direction
        rb.position += new Vector2(-movementSpeed * Time.deltaTime, 0);
    }
}
