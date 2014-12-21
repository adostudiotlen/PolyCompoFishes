using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class logoController : MonoBehaviour 
{
	Image obrazek;

	void Awake()
	{
		obrazek = this.GetComponent<Image> ();
	}

	void Update()
	{
		//obrazek.transform.localScale = new Vector3 (Mathf.Abs (50*Mathf.Sin (Time.time)), Mathf.Abs (50*Mathf.Sin (Time.time)), 1.0f);
		obrazek.transform.localScale = new Vector3 (20+ Mathf.Sin (10*Time.time), 10+ Mathf.Sin (10*Time.time), 1.0f);
		//obrazek.transform.rotation = new Vector3 (0.0f, 0.0f, Mathf.Sin (10 * Time.time));
		//Quaternion obrot = Quaternion.identity;
		//obrot.AngleAxis(Mathf.Sin (10 * Time.time), Vector3.forward);
		//obrazek.transform.rotation = obrot;
		this.transform.rotation = Quaternion.AngleAxis (Mathf.Sin (5 * Time.time), Vector3.forward);
	}
}
