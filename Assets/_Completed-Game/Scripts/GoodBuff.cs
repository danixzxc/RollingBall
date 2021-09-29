using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBuff : CanvasView, IBuff
{
    private void OnTriggerEnter(Collider other)
    {
        Count++;
        SetCountText();
        Debug.Log("Player is buffed!");

    }
    public void Buff()
    {
        Debug.Log("1");
            //buff player
    }
}
