using UnityEngine;
using System.Collections;

public class Damagable : MonoBehaviour {
	public int hp;
	void Start () {
	}
	
	void Update () {
	}
	public void DealDamage(int damage){ //TODO include damage type as well?
		hp -= damage;
		SendMessage("OnDamageDealt", damage, SendMessageOptions.DontRequireReceiver);
		if(hp<=0){
			SendMessage("OnHPDepleted");
		}
	}
}
