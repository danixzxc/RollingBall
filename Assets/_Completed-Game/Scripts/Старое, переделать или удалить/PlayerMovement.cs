using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private readonly string HORIZONTAL = "Horizontal";
	private readonly string VERTICAL = "Vertical";
	private Rigidbody _rb;
	private float _moveHorizontal;
	private float _moveVertical;
	public float Speed = 10f;
	void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

	private void Update()
	{
		_moveHorizontal = Input.GetAxis(HORIZONTAL);
		_moveVertical = Input.GetAxis(VERTICAL);
	}

	private void FixedUpdate()
	{
		Vector3 movement = new Vector3(_moveHorizontal, 0f, _moveVertical);
		_rb.AddForce(movement * Speed);
	}
}
