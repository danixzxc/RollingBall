using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Debug;
using System.Collections;
using UnityEngine.Events;
using System;

//public class PlayerController : IPickUp{
	
//	public delegate void TrapPlayer();
//	public TrapPlayer PlayerBadBonus;
//	public float Speed = 10f;
//	private readonly float  _speedGoodBonus = 1.33f;
//	private readonly float  _speedBadBonus = 0.66f;

//	private void Start ()
//	{
//		PlayerBadBonus += Trap;
//	}
	

//	private void OnTriggerEnter(Collider other)
//	{
//		GameObject gameObject = other.gameObject;
//		if (other.gameObject.CompareTag("Pick Up"))
//			PickUp(true, 1f, gameObject);

//		//if (other.gameObject is IBuff buff)
//			//PickUp(true, 1f, gameObject);
//			//buff.Buff();

//		if (other.gameObject.CompareTag("GoodBonus"))
//			PickUp(true, _speedGoodBonus, gameObject);

//		try
//		{
//			if (other.gameObject.CompareTag("BadBonus")) //GetComponent<Player>
//			{
//				PickUp(false, _speedBadBonus, gameObject);
//				PlayerBadBonus();
//			}
//		}
//		catch
//		{
//			Log("Ошибка при подборе дебафа");
//		}
//	}

//	public void PickUp(bool isUp, float speedBonus, GameObject gameObject)
//	{
		
//		if (isUp) _count++;
//		else _count--;
//		gameObject.SetActive(false);
//		Speed *= speedBonus;
//	}

//	private void Trap() 
//	{
//		Log("Trap!");
//	}
//}