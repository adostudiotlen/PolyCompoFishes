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
                Destroy(coll.gameObject);
            }
            else if (transform.parent.GetComponentInParent<PlayerController>().experience >= 10)
            {
                //nothing happens
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
