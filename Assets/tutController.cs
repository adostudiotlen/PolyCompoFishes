using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tutController : MonoBehaviour 
{
	public float startTime=0;
	void Awake()
	{
		startTime = Time.time;
	}

	void Update()
	{
		if(Time.time - startTime > 5 && this.GetComponent<Text> ().color.a >= 0.1f)
		{
			Debug.Log (Time.time - startTime);
			StartCoroutine(FadeTo(0.0f, 1.0f));
		}

		//Debug.Log (this.GetComponent<Text> ().color.a);
		if(this.GetComponent<Text> ().color.a <= 0.1f)
		{
			//Debug.Log("tututut");
			StopCoroutine("FadeTo");
		}

	}

	IEnumerator FadeTo(float aValue, float aTime)
	{
		//Debug.Log ("testtt");
		float alpha = this.GetComponent<Text> ().color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
		{

			Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha,aValue,t));
			//Debug.Log (newColor);
			this.GetComponent<Text> ().color = newColor;
			yield return null;

		}
	}

	public void RestartText()
	{
		startTime = Time.time;
		this.GetComponent<Text> ().color = new Color (1, 1, 1, 1);
	
	}

}
