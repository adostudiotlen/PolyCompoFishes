using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "MainCamera")
        {
            Destroy(gameObject);
        }
    }
}
