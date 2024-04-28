using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillEvent : MonoBehaviour,Event
{
    Pay _bill;
    string _billname;
    public BillEvent(Pay bill , string _billname)
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
