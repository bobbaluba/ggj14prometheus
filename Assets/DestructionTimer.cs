using UnityEngine;
using System.Collections;

public class DestructionTimer : MonoBehaviour {
	public float lifetime = 5F;
	// Use this for initialization
	void Start () {
		StartCoroutine (WaitBeforeDestroying(lifetime));
	}
	private IEnumerator WaitBeforeDestroying(float seconds){
		yield return new WaitForSeconds (seconds);
		Destroy (gameObject);
	}
}
