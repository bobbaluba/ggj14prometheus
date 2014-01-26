using UnityEngine;
using System.Collections;

public class CreditsText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var mesh = GetComponent<TextMesh>();
		var creditsText = "";
		//creditsText += "Developers:\n";

		creditsText += "Sindre Næss\n";
		creditsText += "Johan Helsing\n";
		creditsText += "\nMusic:\n";
		creditsText += "Chris Zabriskie\n";// - \nThe Temperature of the Air on the Bow of the Kaleetan\n";

		
		var deathsObject = FindObjectOfType<TotalDeathCounter>();
		if(deathsObject){
			creditsText += "\nTotal deaths: "+deathsObject.deaths+"\n";
		}

		mesh.text = creditsText;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
