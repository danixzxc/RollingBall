using UnityEngine;

using UnityEngine.UI;

using static UnityEngine.Debug;

using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	private readonly float  speedGoodBonus = 1.33f;
	private readonly float  speedBadBonus = 0.66f;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	private void Start ()
	{
		rb = GetComponent<Rigidbody>();

		count = 0;

		SetCountText ();

		winText.text = "";
	}

	private void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	private void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			countIncrease(true, 1f, other);
		}

		if (other.gameObject.CompareTag("GoodBonus"))
		{
			countIncrease(true, speedGoodBonus, other);
		}
		if (other.gameObject.CompareTag("BadBonus"))
		{
			countIncrease(false, speedBadBonus, other);
		}
	}

	private void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();

		if (count >= 12) 
		{
			winText.text = "You Win!";
			Log("Victory!");
		}
	}
	private void countIncrease(bool isUp, float speedBonus, Collider other)
	{
		if (isUp) count++;
		else count--;

		SetCountText();
		other.gameObject.SetActive(false);
		speed *= speedBonus;
	}
}