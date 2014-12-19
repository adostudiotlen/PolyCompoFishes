using UnityEngine;
using System.Collections;

public class TrashGenerator : MonoBehaviour 
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
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x)+ transform.position.x, Random.Range(-spawnValues.y,spawnValues.y)+transform.position.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(trash[Random.Range(0, trash.Length)], spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
