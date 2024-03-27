using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillEvent : MonoBehaviour,Event
{
    Bill _bill;

    public BillEvent(Bill bill)
    {
        _bill = bill;
    }

    public void Handle()
    {
        _bill.Reset();
    }

    public bool HasEnded()
    {
        return false;
    }

    
}
