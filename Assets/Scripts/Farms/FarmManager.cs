using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour, Farm
{
    [SerializeField] 
    public int _bankcount=0, _nuclearcount=0, _oilcount = 0;
    int _bankfee=100,_oilfee=100,_nuclearfee= 100;
    float _money;

    private void Update()
    {
        _money = GameManager.Instance.UIManager.money;
    }


    public void BankCount()
    {
         _bankcount+=1;
    }

    public void NuclearCount()
    {
        if (_money > _nuclearfee)
        {
            _nuclearcount += 1;
            GameManager.Instance.UIManager.money -= _nuclearfee;
        }
         

        Debug.Log(_nuclearcount);
    }

    public void OilCount()
    {
         _oilcount+=1;
    }

     
}
