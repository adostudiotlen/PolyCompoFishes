using UnityEngine;
using System.Collections;

public class endController : MonoBehaviour 
{
	AudioSource[] tablica;

	void endAnimation()
	{
		Application.LoadLevel ("menu");
	}

	void playMarch()
	{
		tablica = this.GetComponents<AudioSource> ();
		tablica [1].Play ();
	}
}
