using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour, IButton
{
    
    //BUTTONS
    private Button _farmbutton,_internetbutton,_phonebutton,_waterbutton,_firebutton,_electricbutton;
    //MENU ANIMATIONS
    private Animator _farmmenu,_farmbuttonanm;
    //BUTTON ANIMATIONS
    private Animator _internetbillanm,_waterbillanm,_firebillanm,_electricbillanm,_phonebillanm;

    void Start()
    {
        _farmmenu = GameObject.Find("FarmMenu").GetComponent<Animator>();

         //BUTTON
        _internetbutton = GameObject.Find("Internet").GetComponent<Button>();
        _farmbutton = GameObject.Find("FarmButton").GetComponent<Button>();
        _phonebutton = GameObject.Find("Phone").GetComponent<Button>();
        _waterbutton = GameObject.Find("Water").GetComponent<Button>();
        _firebutton = GameObject.Find("Fire").GetComponent<Button>();
        _electricbutton = GameObject.Find("Electric").GetComponent<Button>();






        //ANIMATIONS
        _internetbillanm = GameObject.Find("Internet").GetComponent<Animator>();
        _farmbuttonanm = GameObject.Find("FarmButton").GetComponent<Animator>();
        _waterbillanm = GameObject.Find("Water").GetComponent<Animator>();
        _firebillanm = GameObject.Find("Fire").GetComponent<Animator>();
        _electricbillanm = GameObject.Find("Electric").GetComponent<Animator>();
        _phonebillanm = GameObject.Find("Phone").GetComponent<Animator>();

    }

    void Update()
    {
        _farmbutton.onClick.AddListener(() => FarmButton());
        _internetbutton.onClick.AddListener(() => Internet());
        _electricbutton.onClick.AddListener(() => Electric());
        _waterbutton.onClick.AddListener(() => Water());
        _firebutton.onClick.AddListener(() => Fire());
        _phonebutton.onClick.AddListener(() => Phone());
    }

    public void FarmButton()
    {
        _farmmenu.SetTrigger("openfarmmenu");
        _farmbuttonanm.SetTrigger("click");
    }

    public void Internet()
    {
        GameManager.Instance.BillManager.ResetInternetBill();
        _internetbillanm.SetTrigger("click");
    }

    public void Electric()
    {
        GameManager.Instance.BillManager.ResetElectrickBill();
        _electricbillanm.SetTrigger("click");
    }

    public void Water()
    {
        GameManager.Instance.BillManager.ResetWaterBill();
        _waterbillanm.SetTrigger("click");
    }

    public void Fire()
    {
        GameManager.Instance.BillManager.ResetFireBill();
        _firebillanm.SetTrigger("click");
    }

    public void Phone()
    {
        GameManager.Instance.BillManager.ResetPhoneBill();
        _phonebillanm.SetTrigger("click");
    }
}
