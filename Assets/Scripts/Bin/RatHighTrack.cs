using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatHighTrack : MonoBehaviour
{
    public float high;
    public float maxHigh;
    public Image highBar;
    // Start is called before the first frame update
    void Start()
    {
        maxHigh = high;
    }

    // Update is called once per frame
    void Update()
    {
        highBar.fillAmount = Mathf.Clamp(high / maxHigh, 0, 1);
        
    }
}
