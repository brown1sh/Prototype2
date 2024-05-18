using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    public int playerLives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddScore(int value)
    {
        playerScore += value;
        Debug.Log("Score: " + playerScore);
    }

    public void RemoveLives(int value)
    {
        playerLives += value;
        Debug.Log("Lives: " + playerLives);
        
        if (playerLives == 0 )
        {
            Debug.Log("Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
