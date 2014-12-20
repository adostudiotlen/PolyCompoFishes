using UnityEngine;
using System.Collections;

public class MouthController : MonoBehaviour 
{
	PlayerController playerController;

	void Awake()
	{
		playerController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "trash") 
		{
			playerController.AddExperience(1);
			Destroy (collider.gameObject);
		}
	}
}
