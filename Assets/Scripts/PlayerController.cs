using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public float speed = 10f;

    private float xRange = 15f;

    private float zMin = -1f;
    private float zMax = 15f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
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

        // keep player within bottom boundary
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        // keep player within top boundary
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        horizontalInput = Input.GetAxis("Horizontal"); // get horizontal inputs
        verticalInput = Input.GetAxis("Vertical"); // get vertical inputs


        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // move player in accordance to inputs
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
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
