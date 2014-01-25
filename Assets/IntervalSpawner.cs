using UnityEngine;
using System.Collections;

public class IntervalSpawner : MonoBehaviour {

	public GameObject objectToSpawn;
	public float respawnInterval = 1F;
	
	private IEnumerator PerformSpawning(){
		while (true) {
			Instantiate(objectToSpawn, transform.position, transform.rotation);
			yield return new WaitForSeconds (respawnInterval);
		}
	}

	void Start(){
		StartCoroutine (PerformSpawning ());
	}
}
