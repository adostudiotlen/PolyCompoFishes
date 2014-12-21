using UnityEngine;
using System.Collections;

public class creditsController : MonoBehaviour 
{

	void Update () 
	{
		if(Input.anyKeyDown)
		{
			Application.LoadLevel("menu");
		}
	}
}
