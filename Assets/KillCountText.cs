using UnityEngine;
using System.Collections;

public class KillCountText : MonoBehaviour {
	private TextMesh text;
	public int deathCounter;
	// Use this for initialization
	void Start () {
		Messenger.AddListener(Events.PlayerDied, OnPlayerDied);
		text = GetComponent<TextMesh> ();
	}
	void OnDestroy(){
		Messenger.RemoveListener(Events.PlayerDied, OnPlayerDied);
	}
	
	// Update is called once per frame
	void Update () {
		if (deathCounter > 0) {
				text.text = "Deaths: " + deathCounter;
		} else {
				text.text = "";
		}
	}

	private void OnPlayerDied(){
		deathCounter++;
	}
}
