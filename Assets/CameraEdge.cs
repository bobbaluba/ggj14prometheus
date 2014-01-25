using UnityEngine;
using System.Collections;

public class CameraEdge : MonoBehaviour {
	public Camera theCamera;
	public int direction = -1;
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.GetComponentInParents<Player>()){
			gameObject.SendMessageUpwards("PlayerAtEdge", other.gameObject);
		}
	}
	void Update(){
		Debug.Log(theCamera.aspect);
		transform.localPosition = Vector3.right*theCamera.orthographicSize*theCamera.aspect*direction;
	}
}
