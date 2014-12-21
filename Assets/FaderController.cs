using UnityEngine;
using System.Collections;

public class faderController : MonoBehaviour 
{
	public void EndGame()
	{
		Application.LoadLevel ("end");
	}
}
