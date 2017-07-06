using UnityEngine;
using System.Collections;

public class ApplyConstantForce : MonoBehaviour {
	public Vector3 force = new Vector2 (0, -1);
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().AddForce (force);
	}
}
