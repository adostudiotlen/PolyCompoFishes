using UnityEngine;
using System.Collections;

public class particleController : MonoBehaviour 
{

	void Start () 
	{
		GetComponent<ParticleSystem>().renderer.sortingLayerName = "Layer2";
		GetComponent<ParticleSystem>().renderer.sortingOrder = 100;
	}
}
