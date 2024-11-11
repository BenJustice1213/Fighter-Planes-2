using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifespan = 2.0f; // Time in seconds before the coin destroys itself
    private GameManager gameManager;

    void Start()
    {
        // Cache the reference to the GameManager
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // Start the coroutine to destroy the coin after a certain time
        StartCoroutine(DestroyAfterTime());
    }

    void Update()
    {
        // Optional: Add movement logic here if you want the coin to move
    }

    private IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.EarnScore(1); // Player earns 1 score
            Destroy(gameObject);
        }
    }
}

}

