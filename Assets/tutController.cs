using UnityEngine;
using System.Collections;

public class tutController : MonoBehaviour 
{
	float startTime=0;
	void Awake()
	{
		startTime = Time.time;
	}

	void Update()
	{
		if((Time.time - startTime) > 5000)
		{
			float alpha = Mathf.Lerp (1.0f, 0.0f, 2.0f);
			//this.guiText.color.a = alpha;
		}
	}

}
