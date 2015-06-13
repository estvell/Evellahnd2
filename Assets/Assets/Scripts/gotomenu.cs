using UnityEngine;
using System.Collections;

public class gotomenu : MonoBehaviour
{
	public void ChangeToMenu(string sceneToMenu)
	{
		Application.LoadLevel (sceneToMenu);
	}
	
}
