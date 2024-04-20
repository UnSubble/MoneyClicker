using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private MoneyManager _moneyManager;
    [SerializeField]
    TextMeshProUGUI _textMeshProUGUI;
    private Button _farmbutton;
    [SerializeField] GameObject _farmmenu, _billmenu;
    [SerializeField]
    public float money = 0;



    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _moneyManager = GameManager.Instance.MoneyManager;
        //StartCoroutine(CheckMoney());
        _farmbutton = GameObject.Find("FarmButton").GetComponent<Button>();



    }

    void Update()
    {
        _textMeshProUGUI.text = _moneyManager.GetFormattedMoney();
    }

    //IEnumerator CheckMoney()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(GameManager.Instance.UICheckMoneyTime);
    //        _textMeshProUGUI.text = _moneyManager.GetFormattedMoney();

    //    }
    //}


    public void UpdateMoney()
    {
        money += 1f;
        Debug.Log(money);

    }
}
