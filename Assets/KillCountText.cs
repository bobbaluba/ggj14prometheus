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
	
	// Update is called once per frame
	void Update () {
		text.text = "Deaths: "+deathCounter;
	}

	private void OnPlayerDied(){
		deathCounter++;
	}
}
