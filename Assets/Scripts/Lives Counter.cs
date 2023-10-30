using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCounter : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;

    public void LoseLife()
    {
        //decrease livesRemaining value
        livesRemaining--;
        lives[livesRemaining].enabled = false; //hide images


        if (livesRemaining==0)
        {
            Debug.Log("Loser!");
        }
    }
//to check if the code works. remove later.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
        }
    }
}
