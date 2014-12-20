using UnityEngine;
using System.Collections;

public class RandomForce : MonoBehaviour 
{
    public float xMaxVelocity;
    public float yMaxVelocity;
	void Start () 
    {
        AddRandomVelocity();
	}

    private void AddRandomVelocity()
    {
        rigidbody2D.velocity = new Vector2(Random.Range(-xMaxVelocity, xMaxVelocity), Random.Range(-yMaxVelocity, yMaxVelocity));
    }
}
