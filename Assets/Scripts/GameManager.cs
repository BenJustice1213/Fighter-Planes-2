using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyOne;
    public GameObject cloud;
    public GameObject coin; // Reference to the coin prefab
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText; // Reference to the Lives Text element

    private int score;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemyOne", 1f, 3f);
        InvokeRepeating("CreateCoin", 2f, 5f); // Create a coin every 5 seconds
        CreateSky();
        score = 0;
        lives = 3; // Initialize lives
        scoreText.text = "Score: " + score;
        UpdateLivesText(); // Update the lives text at the start
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOne, new Vector3(Random.Range(-8f, 8f), 7f, 0), Quaternion.Euler(0, 0, 180));
    }

    void CreateSky()
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }

    void CreateCoin()
    {
        // Generate a random position within the screen bounds
        Vector3 randomPosition = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0);
        Instantiate(coin, randomPosition, Quaternion.identity);
    }

    public void EarnScore(int newScore)
    {
        score = score + newScore;
        scoreText.text = "Score: " + score;
    }

    public void LoseALife()
    {
        lives--;
        UpdateLivesText(); // Update the lives text when a life is lost
        if (lives == 0)
        {
            // Handle game over logic here
        }
    }

    void UpdateLivesText()
    {
        livesText.text = "Lives: " + lives;
    }
}
