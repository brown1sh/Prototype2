using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;

    public float xRange = 15f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PlayerMovement()
    {
        // keep player within left boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // keep player within right boundary
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal"); // get horizontal inputs

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // move player in accordance to inputs
    }

    void PlayerShootProjectile()
    {
        // create projectile upon key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        PlayerShootProjectile();
    }
}
