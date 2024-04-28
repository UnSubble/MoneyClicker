using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour, Farm
{
    [SerializeField] 
    public int _bankcount=0, _nuclearcount=0, _oilcount = 0;
    float _bankfee=300f,_oilfee=500f,_nuclearfee= 600f;
    float _money;

    UIManager u�manager;

    void Start()
    {
        u�manager = GameManager.Instance.UIManager;
    }

    private void Update()
    {
        _money = float.Parse(GameManager.Instance.MoneyManager.GetTotalMoney());
        
    }


    public void BankCount()
    {
        if (_money > _bankfee)
        {
            _bankfee += 1;
            _money -= _bankfee;
            GameManager.Instance.UIManager.money = _money;
            u�manager.bankcount.text = "+ " + _bankcount.ToString();
            _bankfee += 100;
            u�manager.bankfee.text = _bankfee.ToString() + " TL";
        }
    }

    public void NuclearCount()
    {
        if (_money > _nuclearfee)
        {
            _nuclearcount += 1;
            _money -= _nuclearfee;
            GameManager.Instance.UIManager.money = _money;
            u�manager.nuclearcount.text = "+ " + _nuclearcount.ToString();
            _nuclearfee += 100;
            u�manager.nuclearfee.text= _nuclearfee.ToString() + " TL";
        }
        



    }

    public void OilCount()
    {
        if (_money > _oilfee)
        {
            _oilcount += 1;
            _money -= _oilfee;
            GameManager.Instance.UIManager.money = _money;
            u�manager.oilcount.text = "+ " + _oilcount.ToString();
            _oilfee += 100;
            u�manager.oilfee.text = _oilfee.ToString() + " TL";
        }
    }

     
}
