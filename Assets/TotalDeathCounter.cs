using UnityEngine;
using System.Collections;

public class TotalDeathCounter : MonoBehaviour {
	public int deaths {get; private set;}
	void Start(){
		Messenger.AddListener(Events.PlayerDied, OnPlayerDied);
	}

	void OnPlayerDied(){
		deaths++;
	}
}
