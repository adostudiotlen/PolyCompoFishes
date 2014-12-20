using UnityEngine;
using System.Collections;

public class asteroidController : MonoBehaviour 
{

	public void EmitParticles()
	{
		//this.GetComponent<ParticleSystem> ().Emit (10);
		this.particleSystem.Emit (10);
	}

}
