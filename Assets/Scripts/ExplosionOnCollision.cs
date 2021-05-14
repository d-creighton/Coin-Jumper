using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnCollision : MonoBehaviour
{
    public GameObject explosion;        // Explosion animation prefab

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if object is player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get reference to player
            GameObject p = collision.gameObject;

            // Instantiate explosion at current position
            GameObject e = Instantiate(explosion, transform.position, Quaternion.identity);

            // Destroy explosion after short time
            Destroy(e, 0.25f);

            // Destroy coin
            Destroy(this.gameObject);

            // Destroy player
            GameObject.Destroy(p);
        }
    }
}

