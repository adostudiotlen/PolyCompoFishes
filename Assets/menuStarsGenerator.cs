using UnityEngine;
using System.Collections;

public class menuStarsGenerator : MonoBehaviour 
{

	Vector2 center;
	float boxWidth = 10.0f;
	const int starsAmount = 50;
	GameObject[] stars = new GameObject[3];
	Vector3 spawnPoint;
	GameObject[,] tablica = new GameObject[9,starsAmount];

	void Awake()
	{
		stars [0] = transform.FindChild ("Star1").gameObject;
		stars [1] = transform.FindChild ("Star2").gameObject;
		stars [2] = transform.FindChild ("Star3").gameObject;
		center = new Vector2 (-boxWidth, boxWidth);
		for (int i=0; i<9; i++) 
		{
			center= new Vector2(-boxWidth + i%3 * boxWidth, boxWidth - (i/3)*boxWidth);
			for(int j=0; j< starsAmount; j++)
			{
				//Debug.Log ("Spawn");
				spawnPoint = new Vector3(center.x + Random.Range(-boxWidth/2, boxWidth/2), center.y + Random.Range(-boxWidth/2, boxWidth/2), 1.0f);
				//tablica[i][j]  = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
				GameObject gwiazda = Instantiate(stars[Random.Range((int)0,(int)3)], spawnPoint, Quaternion.identity) as GameObject;
				//Instantiate(star, spawnPoint, Quaternion.identity);
				//Transform gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as Transform;
				tablica[i,j] = gwiazda;
			}
			
		}
	}

}
