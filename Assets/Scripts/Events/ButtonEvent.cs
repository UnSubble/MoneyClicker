using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour,Event
{
    Button›nterface button›nterface;
    string _name;
    public void Handle()
    {
        
        button›nterface.Play(_name);
    }

    public ButtonEvent(Button›nterface button›nterface,string _name)
    {
        this.button›nterface = button›nterface;
        this._name = _name;
    }

    public bool HasEnded()
    {
        return false;
    }

    
    
}
