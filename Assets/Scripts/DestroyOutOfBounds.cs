using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30f;
    private float lowerBoundary = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void EntityDestroy()
    {
        // If entity goes off screen, destroy it.
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBoundary)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        EntityDestroy();
    }
}
