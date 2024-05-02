using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour, Farm
{
    [SerializeField] 
    
    float _bankfee=50,_oilfee=10,_nuclearfee= 30;
   


    public void BuyBank()
    {
        if (AAmountPool.money > _bankfee)
        {
            AAmountPool.bankcount += 1;
            AAmountPool.money -= _bankfee;
            UIManager.Instance.bankcount.text =AAmountPool.bankcount.ToString();
            _bankfee += 100;
            UIManager.Instance.bankfee.text = _bankfee.ToString() + " TL";
        }
    }

    public void BuyNuclear()
    {
        if (AAmountPool.money > _nuclearfee)
        {
            AAmountPool.nuclearcount += 1;
            AAmountPool.money -= _nuclearfee;
            UIManager.Instance.nuclearcount.text = AAmountPool.nuclearcount.ToString();
            _nuclearfee += 100;
            UIManager.Instance.nuclearfee.text = _nuclearfee.ToString() + " TL";
        }




    }

    public void BuyGasoline()
    {
        if (AAmountPool.money > _oilfee)
        {
            AAmountPool.gasolinecount += 1;
            AAmountPool.money -= _oilfee;
            UIManager.Instance.oilcount.text = AAmountPool.gasolinecount.ToString();
            _oilfee += 100;
            UIManager.Instance.oilfee.text = _oilfee.ToString() + " TL";
        }
    }


}
