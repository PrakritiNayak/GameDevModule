using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesHearts : MonoBehaviour
{
    public GameObject heartPrefab;
    public Transform heartContainer;
    public int maxLives = 3;  // Set the maximum number of lives
    private int currentLives;

    void Start()
    {
        currentLives = maxLives;
        UpdateHearts();
    }

    void UpdateHearts()
    {
        foreach (Transform child in heartContainer)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < currentLives; i++)
        {
            Instantiate(heartPrefab, heartContainer);
        }
    }

    public void DecreaseLives()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateHearts();

            // Check for game over condition here (e.g., when lives reach 0)
            if (currentLives == 0)
            {
                // Implement game over logic
            }
        }
    }

    public void IncreaseLives()
    {
        if (currentLives < maxLives)
        {
            currentLives++;
            UpdateHearts();
        }
    }
}

