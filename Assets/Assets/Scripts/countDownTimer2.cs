using UnityEngine;
using System.Collections;

public class countDownTimer2 : MonoBehaviour
{

	float timeRemaining = 25;
		// Update is called once per frame
		void Update ()
		{
		timeRemaining -= Time.deltaTime;
		}
	void OnGUI()
	{
		if (timeRemaining > 0) 
		{	
			GUI.contentColor = Color.black;
			GUI.Label(new Rect(10, 30, 200, 100), "Time Remaining: " +(int)timeRemaining);
		}

		else
		{
			Application.LoadLevel(7);
		}
		
	}
}
