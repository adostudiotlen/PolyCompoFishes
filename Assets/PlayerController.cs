using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	float angle;
	GameObject tail;
	GameObject mouth;
	int experience =0;

	void Awake()
	{
		tail = transform.FindChild ("Tail").gameObject;
		mouth = (transform.FindChild("Head")).FindChild ("Mouth").gameObject;
	}

	void Update()
	{
		this.transform.localScale = new Vector3(1.0f + (float)experience * 0.1f,1.0f + (float)experience * 0.1f, 1.0f);
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
		//transform.Rotate (-this.transform.forward, angle * 45.0f * 0.05f);
		rigidbody2D.angularVelocity = angle * -45.0f * 3.0f;
		tail.transform.localRotation = Quaternion.AngleAxis (90 + angle * 45.0f, this.transform.forward);

		if (Input.GetKey (KeyCode.Space)) 
		{

		}

	}

	public void AddExperience(int amount)
	{
		experience += amount;
	}

	public int GetExperience()
	{
		return experience;
	}
}
