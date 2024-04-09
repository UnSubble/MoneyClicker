using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private MoneyManager _moneyManager;
    private TextMeshProUGUI _textMeshProUGUI;
    private Button _farmbutton;
    [SerializeField] GameObject _farmmenu,_billmenu;

    

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _moneyManager = GameManager.Instance.MoneyManager;
        StartCoroutine(CheckMoney());
        _farmbutton=GameObject.Find("FarmButton").GetComponent<Button>();
        
    }

    void Update()
    {
        _farmbutton.onClick.AddListener(()=>Demo());
    }

     IEnumerator CheckMoney()
    { 
        while (true)
        {
            yield return new WaitForSeconds(GameManager.Instance.UICheckMoneyTime);
            _textMeshProUGUI.text = _moneyManager.GetFormattedMoney();
            
        }
    }

    void Demo()
    {
        _farmmenu.SetActive(true);
        _billmenu.SetActive(false);
    }
}
