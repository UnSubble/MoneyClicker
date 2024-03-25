using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject FarmMenu,MainMenu;
    public void OpenFarmMenu()
    {
            FarmMenu.SetActive(true);
           MainMenu.SetActive(false);
    }
}
