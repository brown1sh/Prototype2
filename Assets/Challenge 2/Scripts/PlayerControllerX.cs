using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float coolDown = 1f;
    private bool isCooling = false;

    void CoolDownTime()
    {
        isCooling = false;
    }
    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && isCooling == false)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("CoolDownTime", coolDown);
            isCooling = true;

        }
    }
}
