using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject FarmMenu, MainMenu,CurrencyMenu;
    bool farmmenu;
    public void OpenFarmMenu()
    {
        if (!FarmMenu.activeSelf)
        {
            FarmMenu.SetActive(true);
            MainMenu.SetActive(false);
            CurrencyMenu.SetActive(false);
        }
        else
        {
            FarmMenu.SetActive(false);
            MainMenu.SetActive(true);
            CurrencyMenu.SetActive(false);
        }
       

    }

    public void OpenCurrencyMenu()
    {
        if (!CurrencyMenu.activeSelf)
        {
            CurrencyMenu.SetActive(true);
            MainMenu.SetActive(false);
            FarmMenu.SetActive(false);
        }
        else
        {
            CurrencyMenu.SetActive(false);
            MainMenu.SetActive(true);
            FarmMenu.SetActive(false);
        }
    }
    
    
}
