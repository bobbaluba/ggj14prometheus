using UnityEngine;
using System.Collections;

public class DealDamageOnCollision : MonoBehaviour {
	public int power = 100;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D other){
		var damagable = other.gameObject.GetComponent<Damagable> ();
		if (damagable) {
			damagable.DealDamage(power);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		var damagable = other.gameObject.GetComponentInParents<Damagable> ();
		if (damagable) {
			damagable.DealDamage(power);
		}
	}
}
