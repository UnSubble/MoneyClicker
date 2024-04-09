using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillEvent : MonoBehaviour,Event
{
    Bill _bill;
    string _billname;
    public BillEvent(Bill bill , string _billname)
    {
        _bill = bill;
        this._billname = _billname;
    }

    public void Handle()
    {
        
    }

    public bool HasEnded()
    {
        return false;
    }

    
}
