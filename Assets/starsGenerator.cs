using UnityEngine;
using System.Collections;

public class starsGenerator : MonoBehaviour 
{
	float boxWidth = 300.0f;
	const int starsAmount = 100;
	Vector2 center;
	GameObject star;

	Vector3 spawnPoint;

	GameObject player;
	float xPlayerOffset=0.0f;
	float yPlayerOffset=0.0f;
	int xBox =0;
	int yBox =0;


	GameObject[,] tablica = new GameObject[9,starsAmount];

	void Awake()
	{

		player = GameObject.FindGameObjectWithTag ("Player");
		star = transform.FindChild ("Star").gameObject;
		center = new Vector2 (-boxWidth, boxWidth);
		for (int i=0; i<9; i++) 
		{
			center= new Vector2(-boxWidth + i%3 * boxWidth, boxWidth - (i/3)*boxWidth);
			for(int j=0; j< starsAmount; j++)
			{
				//Debug.Log ("Spawn");
				spawnPoint = new Vector3(center.x + Random.Range(-boxWidth/2, boxWidth/2), center.y + Random.Range(-boxWidth/2, boxWidth/2), 1.0f);
				//tablica[i][j]  = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
				GameObject gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
				//Instantiate(star, spawnPoint, Quaternion.identity);
				//Transform gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as Transform;
				tablica[i,j] = gwiazda;
			}

		}
	}

	void Update()
	{
		xPlayerOffset = player.transform.position.x - (float)xBox * boxWidth;
		yPlayerOffset = player.transform.position.y - (float)yBox * boxWidth;


		//W prawo
		if (xPlayerOffset > boxWidth / 2) 
		{
			xBox++;
			Debug.Log ("kasuj");
			for(int i=0; i<9; i=i+3)
			{
				Debug.Log ("kasuj " + i);
				for(int j=0; j< starsAmount; j++)
				{
					Destroy (tablica[i,j].gameObject);
				}
			}
			for(int i=1; i<9; i++)
			{
				if(((i%3)!=0))
				{
					Debug.Log ( (i) + " -> " + (i-1));
					for(int j=0; j<starsAmount; j++)
					{
						tablica[i-1,j]= tablica[i,j];
					}
				}
			}
			
			for (int i=2; i<9; i=i+3) 
			{
				center= new Vector2(boxWidth + xBox * boxWidth, boxWidth + (-((i-2)/3)+yBox)*boxWidth);
				Debug.Log (center);
				for(int j=0; j< starsAmount; j++)
				{
					//Debug.Log ("Spawn");
					spawnPoint = new Vector3(center.x + Random.Range(-boxWidth/2, boxWidth/2), center.y + Random.Range(-boxWidth/2, boxWidth/2), 1.0f);
					//tablica[i][j]  = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					GameObject gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					//Instantiate(star, spawnPoint, Quaternion.identity);
					//Transform gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as Transform;
					tablica[i,j] = gwiazda;
				}
				
			}

		}
		// W lewo
		else if (xPlayerOffset < -boxWidth / 2)
		{
			xBox--;
			Debug.Log ("kasuj");
			for(int i=2; i<9; i=i+3)
			{
				Debug.Log ("kasuj " + i);
				for(int j=0; j< starsAmount; j++)
				{
					Destroy (tablica[i,j].gameObject);
				}
			}
			for(int i=7; i>=0; i--)
			{
				if(((i+1)%3)!=0)
				{
					Debug.Log ( (i) + " -> " + (i+1));
					for(int j=0; j<starsAmount; j++)
					{
						tablica[i+1,j]= tablica[i,j];
					}
				}
			}

			for (int i=0; i<9; i=i+3) 
			{
				center= new Vector2(-boxWidth + i%3+xBox * boxWidth, boxWidth + (-(i/3)+yBox)*boxWidth);
				Debug.Log (center);
				for(int j=0; j< starsAmount; j++)
				{
					//Debug.Log ("Spawn");
					spawnPoint = new Vector3(center.x + Random.Range(-boxWidth/2, boxWidth/2), center.y + Random.Range(-boxWidth/2, boxWidth/2), 1.0f);
					//tablica[i][j]  = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					GameObject gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					//Instantiate(star, spawnPoint, Quaternion.identity);
					//Transform gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as Transform;
					tablica[i,j] = gwiazda;
				}
				
			}

		}

		// Gora
		if (yPlayerOffset > boxWidth / 2) 
		{
			yBox++;
			Debug.Log ("kasuj");
			for(int i=6; i<9; i++)
			{
				Debug.Log ("kasuj " + i);
				for(int j=0; j< starsAmount; j++)
				{
					Destroy (tablica[i,j].gameObject);
				}
			}
			for(int i=0; i<3; i++)
			{
				
				for(int j=0; j< starsAmount; j++)
				{
					tablica[i+6,j]= tablica[i+3,j];
					tablica[i+3,j]= tablica[i+0,j];
					
				}
				
				
			}
			
			for (int i=0; i<3; i++) 
			{
				center= new Vector2(boxWidth * ((i)%3-1)+xBox * boxWidth, boxWidth + yBox*boxWidth);
				Debug.Log (center);
				for(int j=0; j< starsAmount; j++)
				{
					//Debug.Log ("Spawn");
					spawnPoint = new Vector3(center.x + Random.Range(-boxWidth/2, boxWidth/2), center.y + Random.Range(-boxWidth/2, boxWidth/2), 1.0f);
					//tablica[i][j]  = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					GameObject gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					//Instantiate(star, spawnPoint, Quaternion.identity);
					//Transform gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as Transform;
					tablica[i,j] = gwiazda;
				}
				
			}



		}
		//Dol
		else if (yPlayerOffset< -boxWidth / 2)
		{
			yBox--;
			Debug.Log ("kasuj");
			for(int i=0; i<3; i++)
			{
				Debug.Log ("kasuj " + i);
				for(int j=0; j< starsAmount; j++)
				{
					Destroy (tablica[i,j].gameObject);
				}
			}
			for(int i=0; i<3; i++)
			{

				for(int j=0; j< starsAmount; j++)
				{
					tablica[i,j]= tablica[i+3,j];
					tablica[i+3,j]= tablica[i+6,j];

				}
						

			}
			
			for (int i=6; i<9; i++) 
			{
				center= new Vector2(boxWidth * ((i)%3-1)+xBox * boxWidth, -boxWidth + yBox*boxWidth);
				Debug.Log (center);
				for(int j=0; j< starsAmount; j++)
				{
					//Debug.Log ("Spawn");
					spawnPoint = new Vector3(center.x + Random.Range(-boxWidth/2, boxWidth/2), center.y + Random.Range(-boxWidth/2, boxWidth/2), 1.0f);
					//tablica[i][j]  = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					GameObject gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as GameObject;
					//Instantiate(star, spawnPoint, Quaternion.identity);
					//Transform gwiazda = Instantiate(star, spawnPoint, Quaternion.identity) as Transform;
					tablica[i,j] = gwiazda;
				}
				
			}

		}
		//Debug.Log (xBox + " " + yBox);

	}


}
