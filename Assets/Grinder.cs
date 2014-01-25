using UnityEngine;
using System.Collections;

public class Grinder : MonoBehaviour {
	public float rotationSpeed = 400;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,0,Time.deltaTime*rotationSpeed);
	}
}
