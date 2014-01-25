using UnityEngine;
using System.Collections;

public class GoalArea : MonoBehaviour {
	public string nextScene = "credits";
	public float delayBeforeLoading = 5;
	[System.NonSerialized]
	public bool victory = false;

	void OnTriggerEnter2D(Collider2D other){
		if (!victory) {
			victory = true;
			if (other.gameObject.GetComponentInParents<Player> ()) {
				StartCoroutine(DoVictoryStuff());
			}
		}
		return;
	}

	IEnumerator DoVictoryStuff(){
		Debug.Log ("Victory!");
		yield return new WaitForSeconds (delayBeforeLoading);
		Application.LoadLevel (nextScene);
	}
}
