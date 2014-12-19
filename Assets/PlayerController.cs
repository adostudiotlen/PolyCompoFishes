using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	float angle;
	GameObject tail;

	void Awake()
	{
		tail = transform.FindChild ("Tail").gameObject;
	}

	void Update()
	{

	}

	void FixedUpdate()
	{
		if(Input.GetKey (KeyCode.W))
		{

			this.rigidbody2D.AddForce(-this.transform.right * 0.1f, ForceMode2D.Impulse );
		}

		angle = Input.GetAxis ("Horizontal");
		Debug.Log (angle);
		//this.rigidbody2D.MoveRotation (angle * 45.0f);
		transform.Rotate (-this.transform.forward, angle * 45.0f * 0.05f);
		tail.transform.localRotation = Quaternion.AngleAxis (90 + angle * 45.0f, this.transform.forward);
	}
}
