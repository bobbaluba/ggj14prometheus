using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public int playersAlive = 1;
	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		Messenger.AddListener(Events.PlayerDied, OnPlayerDied);
		SpawnPlayerIfDead();
	}

	private void OnPlayerDied(){
		playersAlive--;
		SpawnPlayerIfDead();
	}

	private void SpawnPlayerIfDead(){
		if(playersAlive<=0){
			GameObject go = Instantiate(playerPrefab, transform.position, transform.rotation) as GameObject;
			playersAlive++;
			Messenger.Broadcast<GameObject>(Events.PlayerSpawned, go);
		}
	}
}
