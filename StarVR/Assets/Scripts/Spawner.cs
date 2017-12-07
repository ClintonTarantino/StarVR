using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] objects;

    public float startWait,
                 spawnWait,
                 waveWait;

    public int enemiesPerWaves;

    public int spawnRange;


	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);

		for (int i = 0; i < enemiesPerWaves; i++)
		{

			GameObject obj = objects[Random.Range(0, objects.Length)];
			Vector3 spawnPosition = new Vector3
				(
				transform.position.x,
				Random.Range(-spawnRange, spawnRange),
				transform.position.z
				);

			Quaternion spawnRotation = new Quaternion(0f, 180f, 0f, 0f);
			Instantiate(obj, spawnPosition, spawnRotation);
			yield return new WaitForSeconds(spawnWait);
		}
		yield return new WaitForSeconds(waveWait);
	}
      

}
