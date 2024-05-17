using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Detect collisions between this game object and another with a collider
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // destroy this game object upon collision
        Destroy(other.gameObject); // destroy other game object upon collision
    }
}
