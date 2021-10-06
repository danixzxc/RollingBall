using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public sealed class GoodBonus : InteractiveObject
{
    private DisplayBonuses _displayBonuses;

    private void Awake()
    {
        _displayBonuses = new DisplayBonuses();
    }

    protected override void Interaction()
    {
        _displayBonuses.Display(5);
    }
}
