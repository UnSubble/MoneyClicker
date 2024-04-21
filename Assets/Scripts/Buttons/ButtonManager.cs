using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour, IButton
{
    
    //BUTTONS
    private Button _farmbutton,_internetbutton,_phonebutton,_waterbutton,_firebutton,_electricbutton;
    //MENU ANIMATIONS
    private Animator _farmmenu;
    

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

        

    }

    void Update()
    {
        _farmbutton.onClick.AddListener(() => FarmButton());
        _internetbutton.onClick.AddListener(() => Internet());
        _electricbutton.onClick.AddListener(() => Electric());
        _waterbutton.onClick.AddListener(() => Water());
        _firebutton.onClick.AddListener(() => Fire());
        _phonebutton.onClick.AddListener(() => Phone());


        GetAllButton();
    }

    void GetAllButton()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach (GameObject button in buttons)
        {
            button.GetComponent<Button>().onClick.AddListener(() => { button.GetComponent<Animator>().SetTrigger("click"); });
        }
    }


    public void FarmButton()
    {
        _farmmenu.SetTrigger("openfarmmenu");
        
    }

    public void Internet()
    {
        GameManager.Instance.BillManager.ResetInternetBill();
        
    }

    public void Electric()
    {
        GameManager.Instance.BillManager.ResetElectrickBill();
        
    }

    public void Water()
    {
        GameManager.Instance.BillManager.ResetWaterBill();
        
    }

    public void Fire()
    {
        GameManager.Instance.BillManager.ResetFireBill();
        
    }

    public void Phone()
    {
        GameManager.Instance.BillManager.ResetPhoneBill();
        
    }
}
