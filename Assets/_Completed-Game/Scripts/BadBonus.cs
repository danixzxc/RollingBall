using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BadBonus : InteractiveObject, IRotation
{
    private float _lengthFly;
    private float _speedRotation;

    private void Awake()
    {
        _lengthFly = Random.Range(1.0f, 5.0f);
        _speedRotation = Random.Range(10.0f, 50.0f);
    }

    protected override void Interaction()
    {
        // Destroy player
    }

    public void Fly()
    {
        transform.localPosition = new Vector3(transform.localPosition.x,
            Mathf.PingPong(Time.time, _lengthFly),
            transform.localPosition.z);
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
