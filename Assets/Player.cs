using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float jumpVelocity = 10;
	public float startSpeed = 4;
	public float noInputDrag = 10F;
	private bool grounded = false;

	
	// Update is called once per frame
	void Update () {
		DoHorizontalMovement();
		if(grounded && Input.GetKeyDown(KeyCode.Space)){
			Jump();
		}
	}
	void DoHorizontalMovement(){
		float horizontal = Input.GetAxis("Horizontal");
		var rb = gameObject.GetComponent<Rigidbody2D>();
		var xspeed = rb.velocity.x;
		if(horizontal!=0){
			if(rb.velocity == Vector2.zero){
				rb.velocity = new Vector2(horizontal, 0)*startSpeed;
			} else {
				rb.AddForce(30*horizontal*transform.right);
			}
		} else {
			rb.SetXVelocity(xspeed*0.5f);
		}
	}

	void TouchDown(){
		grounded = true;
	}

	void Jump(){
		Vector2 vel = GetComponent<Rigidbody2D>().velocity;
		GetComponent<Rigidbody2D>().velocity = vel + (transform.up * jumpVelocity).To2D();
		grounded = false;
	}

	void OnHPDepleted(){
		Messenger.Broadcast(Events.PlayerDied);
	}
}
