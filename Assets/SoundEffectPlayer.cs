using UnityEngine;
using System.Collections;

public class SoundEffectPlayer : MonoBehaviour {
	[System.Serializable]
	public class SoundEffect{
		public AudioClip soundFile;
		[Range(0F,1F)]
		public float volume = 1F;

		public void PlayAtPosition(Vector3 pos){
			AudioSource.PlayClipAtPoint(soundFile, pos, volume);
		}
	}
	private Vector3 defaultPos {get{return Camera.main.transform.position;}}
	
	public SoundEffect dieSound;
	
	void Start(){
		Messenger.AddListener(Events.PlayerDied, PlayDieSound);
	}
	
	void PlayDieSound(){
		dieSound.PlayAtPosition(defaultPos);
	}
}