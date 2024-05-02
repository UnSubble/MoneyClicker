using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AAmountPool
{
    public static float money { get; set; }

    public static int bankcount { get; set; }

    public static int nuclearcount { get; set; }

    public static int gasolinecount { get; set; }

    public static float rentpay { get { return float.Parse(UIManager.Instance.rentpay.text); } set { } }

    public static float taxpay { get { return float.Parse(UIManager.Instance.taxpay.text); } set { } }

    public static float employeepay { get { return float.Parse(UIManager.Instance.employeepay.text); } set { } }

    public static float billpay { get { return float.Parse(UIManager.Instance.billpay.text); } set { } }

    public static float bitcoinamount { get; set; }

    public static float dolaramount { get; set; }

    public static float euroamount { get; set; }

    public static float dollarinstant { get { return float.Parse(UIManager.Instance.dollarinstant.text); } set { } }

    public static float euroinstant { get { return float.Parse(UIManager.Instance.euroinstant.text); } set { } }

    public static float bitcoininstant { get { return float.Parse(UIManager.Instance.bitcoininstant.text); } set { } }



}


