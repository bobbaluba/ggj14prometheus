﻿using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public int playersAlive = 1;
	public GameObject playerPrefab;
	public float respawnDelay = 0.5F;

	// Use this for initialization
	void Start () {
		Messenger.AddListener(Events.PlayerDied, OnPlayerDied);
		SpawnPlayerIfDead();
	}
	void OnDestroy(){
		Messenger.RemoveListener(Events.PlayerDied, OnPlayerDied);
	}

	private void OnPlayerDied(){
		playersAlive--;
		StartCoroutine (WaitBeforeSpawning(respawnDelay));
	}
	

	private IEnumerator WaitBeforeSpawning(float seconds){
		yield return new WaitForSeconds (seconds);
		SpawnPlayerIfDead ();
	}

	private void SpawnPlayerIfDead(){
		if(playersAlive<=0){
			GameObject go = Instantiate(playerPrefab, transform.position, transform.rotation) as GameObject;
			playersAlive++;
			Messenger.Broadcast<GameObject>(Events.PlayerSpawned, go);
		}
	}
}
