using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighBar : MonoBehaviour
{
    public Image fillBar;
    public float high;

    public void Sober(int value)
    {
        if (high <= 0) //do nothing if not high
            return;
        
        high -= value;
        fillBar.fillAmount = high / 100;

        if (high<=0)
        {
        Debug.Log("Borrriiiiing!");
        }
    }
//to test; remove when applying
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            Sober(25);
    }
    
}
