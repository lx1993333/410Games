using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rd2d;
	public float Speed;

	void Start()
	{
		rd2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movment = new Vector2 (moveHorizontal, moveVertical);
		rd2d.AddForce(movment * Speed);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
		}
	}


}
