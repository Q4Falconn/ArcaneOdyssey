using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerIntentory = other.GetComponent<PlayerInventory>();

        if (playerIntentory != null)
        {
            playerIntentory.Collected();
            scoreManager.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
