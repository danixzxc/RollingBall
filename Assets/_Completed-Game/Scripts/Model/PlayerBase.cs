using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    public float Speed = 3.0f;

    public abstract void Move(float x, float y, float z);
}
