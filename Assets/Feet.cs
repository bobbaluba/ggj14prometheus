using UnityEngine;
using System.Collections;

public class Feet : MonoBehaviour {
	// Update is called once per frame
	void OnTriggerEnter2D() {
		gameObject.SendMessageUpwards("TouchDown");
	}
}
