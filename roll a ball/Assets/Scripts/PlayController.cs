using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayController : MonoBehaviour 
{

	public float speed;
	public Text countText;
	public Text WinText;

	private Rigidbody rb;
	private int count;

	// Use this for initialization

	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		WinText.text = "";
	}
	
	// Update is called once per frame


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 

		rb.AddForce (movement * speed);
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick_up")) 
		{
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			WinText.text = "You Win!!";
		}
	}
}

