using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ButtonScript: MonoBehaviour
{
    public EventHandler click;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        Debug.Log("ad");

        if (click != null)
        {
            click(this, EventArgs.Empty);
        }
    }
}
