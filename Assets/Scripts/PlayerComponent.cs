using UnityEngine;
using System.Collections;

public class PlayerComponent : MonoBehaviour
{
	public float speed;
	public GUIText Score;
	public GUIText winText;
	
	private Rigidbody rb;
	private int count;


	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetScore ();
		winText.text = "";




	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Mouse X");
		float moveVertical = Input.GetAxis ("Mouse Y");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);

	}

		void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);	
			count = count +1;
			SetScore();
		}
	}

	void SetScore ()
	{
		Score.text = "Score: " + count.ToString ();
		if (count >= 11) 
		{
			winText.text="Level 1 Accomplished!";
		}
	}




}

