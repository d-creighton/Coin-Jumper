using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coinPrefab;               // Object to spawn
    public int spawnTime;                       // Random time between spawns
    public float secondsSinceLast = 0.0f;       // Time between spawns

    private int generateSpawn()
    {
        // Generate random spawn time in range 2-5 seconds
        spawnTime = Random.Range(2, 5);

        return spawnTime;
    }

    void Start()
    {
        // Initital spawn time
        generateSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        // Add time since last call to Update
        secondsSinceLast += Time.deltaTime;

        // If total time more than time between spawns
        if (secondsSinceLast >= spawnTime)
        {
            // Spawn a new coin at location and rotation
            GameObject coin = Instantiate(coinPrefab, transform.position, transform.rotation);

            // Reset spawn time
            generateSpawn();

            // Reset timer
            secondsSinceLast = 0;
        }
    }
}
