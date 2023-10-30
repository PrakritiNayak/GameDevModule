using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighBar : MonoBehaviour
{
    private Transform bar;
    // Start is called before the first frame update
    private void Start()
    {
        bar = transform.Find("Bar");
    }

    // Update is called once per frame
    public void SetSize(float sizeNormalised)
    {
       bar.localScale = new Vector3(sizeNormalised, 1f); 
    }
}
