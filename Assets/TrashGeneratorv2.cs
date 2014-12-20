using UnityEngine;
using System.Collections;

public class TrashGeneratorv2 : MonoBehaviour 
{
	public Vector3 spawnValues;
	public int trashCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public GameObject[] trash;



	void Start () 
	{
		StartCoroutine(SpawnTrash());
	}

	IEnumerator SpawnTrash()
	{
		yield return new WaitForSeconds(startWait);
		while (true)
		{
			for (int i = 0; i < trashCount; i++)
			{
				Vector3 spawnPoint;
				if((Random.Range(0.0f,1.0f)>0.5f))
				{
					if((Random.Range(0.0f,1.0f)>0.5f))
					{
						spawnPoint = new Vector3(-40.0f+ transform.position.x, Random.Range(-20.0f, 20.0f)+transform.position.y, 0.0f);
					}
					else
					{
						spawnPoint = new Vector3(40.0f+ transform.position.x, Random.Range(-20.0f, 20.0f)+transform.position.y, 0.0f);
					}
				}
				else
				{
					if((Random.Range(0.0f,1.0f)>0.5f))
					{
						spawnPoint = new Vector3(Random.Range(-20.0f, 20.0f)+ transform.position.x, -40.0f+transform.position.y, 0.0f);
					}
					else
					{
						spawnPoint = new Vector3(Random.Range(-20.0f, 20.0f)+ transform.position.x, 40.0f+transform.position.y, 0.0f);
					}
				}

				//Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x)+ transform.position.x, Random.Range(-spawnValues.y,spawnValues.y)+transform.position.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(trash[Random.Range(0, trash.Length)], spawnPoint, spawnRotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
