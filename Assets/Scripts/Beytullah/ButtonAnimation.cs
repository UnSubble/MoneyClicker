using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour,Button›nterface
{
    Animator anm;
    public void Play(string _name)
    {
        anm = GameObject.Find(_name).GetComponent<Animator>();
        anm.SetTrigger("click");
    }

        
        






}
