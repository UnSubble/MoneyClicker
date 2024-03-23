using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    private Queue<Event> _events = new Queue<Event>();

    private void Start()
    {
        _events = new Queue<Event>();
    }

    private void Update()
    {
        if (_events.Count > 0)
        {
            Event event_ = _events.Dequeue();
            event_.Handle();
        }
    }

    public void Enqueue(Event event_)
    {
        _events.Enqueue(event_);
    }
}
