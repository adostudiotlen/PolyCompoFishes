using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour 
{

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
            if(transform.parent.GetComponentInParent<PlayerController>().experience < 800)
            {
                transform.parent.GetComponentInParent<PlayerController>().healthPoints= transform.parent.GetComponentInParent<PlayerController>().healthPoints-4;
            }
            else if(transform.parent.GetComponentInParent<PlayerController>().experience >= 800)
            {
                //nothing happens
            }
        }
    }

}
