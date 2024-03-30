using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour,Event
{
    ButtonManager buttonManager;
    public void Handle()
    {
        buttonManager.PlayAnimation();
    }

    public ButtonEvent(ButtonManager buttonManager)
    {
        this.buttonManager = buttonManager;
    }

    public bool HasEnded()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    
}
