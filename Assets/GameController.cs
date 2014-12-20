using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{

	public void Play()
	{
		Application.LoadLevel ("play");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
