using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int feedAmount;

    private int currentAmountFed;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = feedAmount;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void FeedAnimal (int amount)
    {
        currentAmountFed += amount;
        hungerSlider.fillRect.gameObject.SetActive (true);
        hungerSlider.value = currentAmountFed;

        if (currentAmountFed >= feedAmount)
        {
            gameManager.AddScore(feedAmount);
            Destroy(gameObject, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
