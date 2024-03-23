using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEvent : MonoBehaviour, Event
{
    public void Handle()
    {
        
    }

    public bool HasEnded()
    {
        return true;
    }
}
