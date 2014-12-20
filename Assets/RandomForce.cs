using UnityEngine;
using System.Collections;

public class RandomForce : MonoBehaviour 
{
	GameObject player;
    public float xMaxVelocity;
    public float yMaxVelocity;
	void Start () 
    {
		player = GameObject.FindGameObjectWithTag ("Player");
        AddRandomVelocity();
	}



    private void AddRandomVelocity()
    {
		float x;
		float y;

		if (this.transform.position.x >= player.transform.position.x) 
		{
			x=Random.Range(-xMaxVelocity, 0);
		}
		else
		{
			x=Random.Range(0, xMaxVelocity);
		}

		if (this.transform.position.y >= player.transform.position.y) 
		{
			y=Random.Range(-yMaxVelocity, 0);
		}
		else
		{
			y=Random.Range(0, yMaxVelocity);

		}

        rigidbody2D.velocity = new Vector2(x, y);
    }
}
