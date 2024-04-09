using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour, Button›nterface
{
    Animator anm;
    public void Play()
    {
        anm.SetTrigger("click");
    }
}
