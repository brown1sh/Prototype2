using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private GameManager gameManager;
    //private AnimalHunger animalHunger;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //animalHunger = GameObject.Find("AnimalHunger").GetComponent<AnimalHunger>();    
    }

    // Update is called once per frame
    void Update()
    {
    }


    //Detect collisions between this game object and another with a collider
    private void OnTriggerEnter(Collider other)
    {
        if (this.tag != "Player" && other.tag == "Enemy")
        {
            //gameManager.AddScore(+1);
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
            //Destroy(other.gameObject); // destroy other game object upon collision
        }
        else if (other.tag == "Enemy" && this.tag == "Player")
        {
            gameManager.RemoveLives(-1);
        }

    }
}
