using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenInvisible : MonoBehaviour
{
    // Called when object this script is attached to
    // leaves camera range
    private void OnBecameInvisible()
    {
        // Destroy game object script attached to
        Destroy(this.gameObject);
    }
}
