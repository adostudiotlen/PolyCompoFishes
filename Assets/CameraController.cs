using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{

	GameObject player;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, this.transform.position.z); 
	}

}
