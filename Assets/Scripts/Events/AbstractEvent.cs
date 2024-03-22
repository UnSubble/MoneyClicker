using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractEvent : MonoBehaviour, Event
{
    public bool HasEnded()
    {
        return false;
    }
}
