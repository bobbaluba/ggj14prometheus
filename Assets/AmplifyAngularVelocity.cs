using UnityEngine;
using System.Collections;

public class AmplifyAngularVelocity : MonoBehaviour {
	public float torque = 1;
	// Update is called once per frame
	void Update () {
		rigidbody2D.AddTorqueAtPosition(torque*Mathf.Sign(rigidbody2D.angularVelocity), Vector2.zero); 
	}
}
