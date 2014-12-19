using UnityEngine;
using System.Collections;

public class RandomForce : MonoBehaviour 
{

	void Start () 
    {
        AddRandomVelocity();
	}

    private void AddRandomVelocity()
    {
        rigidbody2D.velocity= new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
    }
}
