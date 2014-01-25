using UnityEngine;
using System.Collections;

public class BulletFlight : MonoBehaviour {
	public Vector2 velocity = new Vector2(1,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = velocity.To3D ();

		//gameObject.constantForce.force.Set (xPow, yPow, zPow);
	
	}
}
