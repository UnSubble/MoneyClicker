using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : AbstractBuilding
{
    private void Start()
    {
        _capacity = 10;
    }

    private new void Update()
    {
        base.Update();
    }
}
