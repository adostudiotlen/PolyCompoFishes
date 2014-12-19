using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
    public void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "MainCamera")
        {
            Destroy(gameObject);
        }
    }
}
