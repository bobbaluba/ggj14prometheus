using UnityEngine;
using System.Collections;

public class DestroyOnHPDepleted : MonoBehaviour {
	public Rigidbody2D[] gibs;
	
	public float explosionRadius = 2.0f;
	public float explosionPower = 100.0f;
	public Transform explosionOffset;
	
	void OnHPDepleted(){
		Destroy(gameObject);
		foreach(Rigidbody2D gib in gibs){
			Rigidbody2D instance = Instantiate(gib, explosionOffset.position+(Random.insideUnitCircle*explosionRadius*0.5f).To3D(), Quaternion.AngleAxis(Random.Range(0,360),Vector3.forward)) as Rigidbody2D;
			instance.velocity = new Vector2(Random.Range(-explosionPower, explosionPower),
			                                Random.Range(-explosionPower, explosionPower));
			//instance.AddExplosionForce(explosionPower, explosionOffset.position, explosionRadius);
		}
	}
}
