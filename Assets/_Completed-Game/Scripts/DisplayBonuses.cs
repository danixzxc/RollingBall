using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class DisplayBonuses
{
    private Text _bonuseLable;

    public DisplayBonuses(GameObject bonus)
    {
        _bonuseLable = bonus.GetComponentInChildren<Text>();
        _bonuseLable.text = string.Empty;
    }

    public void Display(int value)
    {
        _bonuseLable.text = $"�� ������� {value}";
    }
}
