using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour 
{
	AudioSource[] sounds;

	void Awake()
	{
		sounds = this.GetComponents<AudioSource> ();
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "asteroid")
        {
            if (transform.parent.GetComponentInParent<PlayerController>().experience < 10)
            {
                transform.parent.GetComponentInParent<PlayerController>().healthPoints--;
				coll.gameObject.collider2D.enabled = false;
				coll.gameObject.renderer.enabled = false;
                Destroy(coll.gameObject, 5.0f);
				coll.gameObject.GetComponent<asteroidController>().EmitParticles();
				this.sounds[1].Play();
            }
            else if (transform.parent.GetComponentInParent<PlayerController>().experience >= 10 && transform.parent.GetComponentInParent<PlayerController>().experience < 100)
            {
                //nothing happens
            }
            else if (transform.parent.GetComponentInParent<PlayerController>().experience >= 100)
            {
                Destroy(coll.gameObject);
            }
        }
        
        if(coll.gameObject.tag == "sun")
        {
            if(transform.parent.GetComponentInParent<PlayerController>().experience < 500)
            {
                transform.parent.GetComponentInParent<PlayerController>().healthPoints= transform.parent.GetComponentInParent<PlayerController>().healthPoints-4;
				this.sounds[0].Play();
            }
            else if(transform.parent.GetComponentInParent<PlayerController>().experience >= 500)
            {
                //nothing happens
            }
        }
    }

}
