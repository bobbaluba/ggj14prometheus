using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	public float cameraSpeed = 10F;
	Vector2 goalPosition;

	void Start(){
		goalPosition = transform.position.To2D();
		Messenger.AddListener<GameObject>(Events.PlayerSpawned, PlayerAtEdge);
	}

	void Update(){
		var curPos = transform.position;
		var curPos2D = curPos.To2D();
		var offset = (goalPosition - curPos2D);
		var newPos2D = curPos2D + offset * cameraSpeed * Time.deltaTime;
		transform.position = newPos2D.To3D(curPos.z);
	}

	void PlayerAtEdge(GameObject player){
		Debug.Log("Changing goal pos");
		goalPosition = player.transform.position.To2D();
	}
}
