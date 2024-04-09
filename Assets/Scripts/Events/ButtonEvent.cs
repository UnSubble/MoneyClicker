using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent :Event
{
    Button›nterface button›nterface;
    
    public void Handle()
    {
        
        button›nterface.Play();
    }

    public ButtonEvent(Button›nterface button›nterface)
    {
        this.button›nterface = button›nterface;
    }

    public bool HasEnded()
    {
        return false;
    }

    
    
}
