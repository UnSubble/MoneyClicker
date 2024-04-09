using System.Collections;
using System.Collections.Generic;
using UnityEditor.AddressableAssets.HostingServices;
using UnityEngine;

public interface Bill
{
    public void ResetElectrickBill();

    public void ResetWaterBill();

    public void ResetPhoneBill();

    public void ResetFireBill();

    public void ResetInternetBill();
    


}
