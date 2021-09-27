using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Debug;
using System.Collections;
using UnityEngine.Events;
using System;

public class PlayerController : MonoBehaviour, IPickUp{
	
	public delegate void TrapPlayer();
	public TrapPlayer PlayerBadBonus;
	public float Speed = 10f;
	public Text CountText;
	public Text WinText;
	private readonly float  _speedGoodBonus = 1.33f;
	private readonly float  _speedBadBonus = 0.66f;
	private readonly int _winCount= 12;
	private Rigidbody _rb;
	private int _count;
	private float _moveHorizontal;
	private float _moveVertical;
	private void Start ()
	{
		PlayerBadBonus += Trap;
		_rb = GetComponent<Rigidbody>();
		_count = 0;
		SetCountText ();
		WinText.text = string.Empty;
	}
	private void Update()
	{
		_moveHorizontal = Input.GetAxis("Horizontal");
		_moveVertical = Input.GetAxis("Vertical");
	}		

	private void FixedUpdate ()
	{
		Vector3 movement = new Vector3 (_moveHorizontal, 0f, _moveVertical);
		_rb.AddForce (movement * Speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject gameObject = other.gameObject;
		if (other.gameObject.CompareTag("Pick Up"))
			PickUp(true, 1f, gameObject);

		//if (other.gameObject is IBuff buff)
			//PickUp(true, 1f, gameObject);
			//buff.Buff();

		if (other.gameObject.CompareTag("GoodBonus"))
			PickUp(true, _speedGoodBonus, gameObject);

		try
		{
			if (other.gameObject.CompareTag("BadBonus")) //GetComponent<Player>
			{
				PickUp(false, _speedBadBonus, gameObject);
				PlayerBadBonus();
			}
		}
		catch
		{
			Log("Ошибка при подборе дебафа");
		}
	}

	private void SetCountText()
	{
		CountText.text = $"Count: {_count}";
		if (_count >= _winCount) 
		{
			WinText.text = "You Win!";
			Log("Victory!");
		}
	}
	public void PickUp(bool isUp, float speedBonus, GameObject gameObject)
	{
		
		if (isUp) _count++;
		else _count--;
		SetCountText();
		gameObject.SetActive(false);
		Speed *= speedBonus;
	}

	private void Trap() 
	{
		Log("Trap!");
	}
}