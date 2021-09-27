using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBuff : MonoBehaviour, IBuff
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player is buffed!");

    }
    public void Buff()
    {
        Debug.Log("1");
            //buff player
    }
}
