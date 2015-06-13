using UnityEngine;
using System.Collections;

public class PlayerThree : MonoBehaviour
{
	public float speed;
	public GUIText Score;
	public GUIText winText;
	public AudioClip playerCollectSound;
	
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

			AudioSource.PlayClipAtPoint(playerCollectSound, transform.position);
			other.gameObject.SetActive(false);	
			count = count +1;
			SetScore();
		}
	}

	void SetScore ()
	{
		Score.text = "Score: " + count.ToString ();
		if (count >= 44) 
		{


			winText.text="You won the game";
			Application.LoadLevel(8);

		}
	}




}

