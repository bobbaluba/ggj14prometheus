using UnityEngine;
using System.Collections;

public class FadeInLight : MonoBehaviour {
	public AnimationCurve intensityAnimation = AnimationCurve.Linear(0,0,1,1);
	public AnimationCurve rangeAnimation = AnimationCurve.Linear(0,0,1,1);
	private float goalRange;
	private float goalIntensity;


	// Use this for initialization
	void Start () {
		goalRange = light.range;
		light.range = 0;
		goalIntensity = light.intensity;
		light.intensity = 0;
		StartCoroutine(FadeInIntensity());
		StartCoroutine(FadeInRange());
	}

	IEnumerator FadeInIntensity(){
		for(float time = 0; time < intensityAnimation.length; time += Time.deltaTime){
			light.intensity = goalIntensity * intensityAnimation.Evaluate(time);
			yield return null;
		}
		light.intensity = goalIntensity;
	}

	IEnumerator FadeInRange(){
		for(float time = 0; time < rangeAnimation.length; time += Time.deltaTime){
			light.range = goalRange * rangeAnimation.Evaluate(time);
			yield return null;
		}
		light.range = goalRange;
	}
}
