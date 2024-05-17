using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MoveEntity()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // move entity in forward direction
    }

    // Update is called once per frame
    void Update()
    {
        MoveEntity();
    }
}
