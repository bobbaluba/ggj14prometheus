using UnityEngine;
using System.Collections;

public class GoalArea : MonoBehaviour {
	public string nextScene = "credits";
	public float delayBeforeLoading = 5;
	[System.NonSerialized]
	public bool victory = false;
	public GameObject[] activateOnVictory;

	void OnTriggerEnter2D(Collider2D other){
		if (!victory) {
			if (other.gameObject.GetComponentInParents<Player> ()) {
				StartCoroutine(DoVictoryStuff());
			}
		}
		return;
	}

	IEnumerator DoVictoryStuff(){
		victory = true;
		Debug.Log ("Victory!");
		foreach(var g in activateOnVictory){
			g.SetActive(true);
		}
		yield return new WaitForSeconds (delayBeforeLoading);
		Application.LoadLevel (nextScene);
	}
}
