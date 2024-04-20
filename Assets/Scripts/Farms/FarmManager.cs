using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour, Farm
{
    private int _bankcount, _nuclearcount, _oilcount;


    public void BankCount()
    {
         _bankcount+=1;
    }

    public void NuclearCount()
    {
         _nuclearcount+=1;
    }

    public void OilCount()
    {
         _oilcount+=1;
    }
}
