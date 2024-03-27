using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private MoneyManager _moneyManager;
    private TextMeshProUGUI _textMeshProUGUI;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _moneyManager = GameManager.Instance.MoneyManager;
        StartCoroutine(CheckMoney());
        
    }

    void Update()
    {

    }

    private IEnumerator CheckMoney()
    { 
        while (true)
        {
            Debug.Log("money checked");
            yield return new WaitForSeconds(GameManager.Instance.UICheckMoneyTime);
            _textMeshProUGUI.text = _moneyManager.GetFormattedMoney();
            
        }
    }
}
