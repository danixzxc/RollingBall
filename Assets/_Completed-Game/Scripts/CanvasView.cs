using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasView : MonoBehaviour
{
    public int Count;
    public string WinText = "You Win!";
    public Text CountText;
    public Text VictoryText;
    public readonly int WinCount = 12;
    void Start()
    {
        Count = 0;
        Debug.Log(Count);
        SetCountText();
        VictoryText.text = string.Empty;
    }
    public void SetCountText()
    {
        Debug.Log(Count);
        CountText.text = $"Count: {Count}";
        if (Count >= WinCount)
        {
            VictoryText.text = WinText;
        }
    }
}
