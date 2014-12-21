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
			playerController.PlayEatingAnim();
			Destroy (collider.gameObject);
		}
		if (collider.tag == "asteroid" && (playerController.GetExperience () >= 10))
		{
			playerController.AddExperience(10);
			playerController.PlayEatingAnim();
			Destroy (collider.gameObject);
		}
        if (collider.tag == "planet" && (playerController.GetExperience() >= 100))
        {
            playerController.AddExperience(100);
            playerController.PlayEatingAnim();
            Destroy(collider.gameObject);
        }
        if (collider.tag == "sun" && (playerController.GetExperience() >= 500))
        {
            playerController.AddExperience(3000);
            playerController.PlayEatingAnim();
            Destroy(collider.gameObject);
        }
	}
}
