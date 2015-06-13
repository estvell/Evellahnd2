using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour
{
	public float speed;
	public GUIText Score;
	public GUIText winText;
	public AudioClip collectSound;
	
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
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
			other.gameObject.SetActive(false);	
			count = count +1;
			SetScore();
		}
	}

	void SetScore ()
	{
		Score.text = "Score: " + count.ToString ();
		if (count >= 20) 
		{
			winText.text="Level 2 Accomplished!";
			Application.LoadLevel(5);
		}
	}




}

