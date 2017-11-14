using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraShake : MonoBehaviour {

	[Range(0,1)]public float intensity;
	public float frequency;
	public float shakePower;
	public float decay;
	
	
	private void Update () {
		intensity = Mathf.Clamp01(intensity);
		
		var time = Time.time * frequency;
		var offset = new Vector3(Mathf.PerlinNoise(time,0) - 0.5f,Mathf.PerlinNoise(0,time) - 0.5f,0) * shakePower;
		transform.localPosition = offset * intensity;

		intensity -= Time.deltaTime * decay;
	}
}
