using UnityEngine;
using System.Collections;

public class PlanetaryMovement : MonoBehaviour 
{
    //GameObject planet1;
    //GameObject planet2;
    //GameObject planet3;
    //GameObject planet4;
    //GameObject planet5;
    //GameObject planet6;
    //GameObject planet7;
    //GameObject planet8;
    GameObject sun;

    float planetSpeed;
    //float[] speedMulti = new float[8];
    void Awake()
    {
        sun = transform.GetComponentInParent<Transform>().gameObject;
        //planet1 = transform.FindChild("planeta1").gameObject;
        //planet2 = transform.FindChild("planeta2").gameObject;
        //planet3 = transform.FindChild("planeta3").gameObject;
        //planet4 = transform.FindChild("planeta4").gameObject;
        //planet5 = transform.FindChild("planeta5").gameObject;
        //planet6 = transform.FindChild("planeta6").gameObject;
        //planet7 = transform.FindChild("planeta7").gameObject;
        //planet8 = transform.FindChild("planeta8").gameObject;

        planetSpeed = Random.Range(100.0f, 700.0f);
        //for (int i = 0; i == 8; i++)
        //{
        //    speedMulti[i] = Random.Range(1.0f, 7.0f);
        //}
    }
	

	void Update ()
    {
        new Vector3((sun.transform.position.x + 100 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 1))), (sun.transform.position.y + 100 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 1))), 0);
        //planet1.transform.position = new Vector3((transform.position.x + 100 * Mathf.Cos((Mathf.PI * Time.time)/(planetSpeed * 1))), (transform.position.y + 100 * Mathf.Sin((Mathf.PI * Time.time)/(planetSpeed * 1))),0);
        //planet2.transform.position = new Vector3((transform.position.x + 200 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 2))), (transform.position.y + 200 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 2))), 0);
        //planet3.transform.position = new Vector3((transform.position.x + 250 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 3))), (transform.position.y + 250 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 3))), 0);
        //planet4.transform.position = new Vector3((transform.position.x + 300 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 4))), (transform.position.y + 300 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 4))), 0);
        //planet5.transform.position = new Vector3((transform.position.x + 350 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 5))), (transform.position.y + 350 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 5))), 0);
        //planet6.transform.position = new Vector3((transform.position.x + 400 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 6))), (transform.position.y + 400 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 6))), 0);
        //planet7.transform.position = new Vector3((transform.position.x + 450 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 7))), (transform.position.y + 450 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 7))), 0);
        //planet8.transform.position = new Vector3((transform.position.x + 500 * Mathf.Cos((Mathf.PI * Time.time) / (planetSpeed * 8))), (transform.position.y + 500 * Mathf.Sin((Mathf.PI * Time.time) / (planetSpeed * 8))), 0);

	}
}
