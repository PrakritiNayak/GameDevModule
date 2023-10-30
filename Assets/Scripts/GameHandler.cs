using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private HighBar highBar;

    void Start()
    {
        float high = 1f;

        FunctionPeriodic.Create(() => {
            if (high > 0) {
                high -= .005f;
                highBar.SetSize(high);

            }
        }, .09f);
    }

    
}
