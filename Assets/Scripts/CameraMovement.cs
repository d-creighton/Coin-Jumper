using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;           // GameObject camera follows
    Rigidbody2D rb;                     // Its Rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get player x-coordinate
        float playerX = rb.position.x;

        // Get camera y and z
        float cameraY = transform.position.y;
        float cameraZ = transform.position.z;

        // Move camera to that position
        transform.position = new Vector3(playerX, cameraY, cameraZ);
    }
}
