using UnityEngine;
using System.Collections;

public class AmplifyAngularVelocity : MonoBehaviour {
	public float torque = 1;
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().AddTorqueAtPosition(torque*Mathf.Sign(GetComponent<Rigidbody2D>().angularVelocity), Vector2.zero); 
	}
}
