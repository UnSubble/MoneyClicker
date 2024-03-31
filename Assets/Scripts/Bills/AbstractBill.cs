using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBill : MonoBehaviour, Bill
{

    public void Reset()
    {
        Debug.Log("bill");
    }
}
