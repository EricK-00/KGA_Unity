using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ButtonScript: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmp;
    public EventHandler click;
    private bool play = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ControlButton()
    {
        Debug.Log("Click");
        play = !play;
        tmp.text = play ? "Pause" : "Play";
        if (click != null)
        {
            click(this, EventArgs.Empty);
        }
    }
}
