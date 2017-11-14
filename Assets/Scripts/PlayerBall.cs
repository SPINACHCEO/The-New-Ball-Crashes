using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : Ball {

	public CameraShake shaker;
	public float intensityFactor;

	public override void OnCollisionEnter(Collision other) {
		base.OnCollisionEnter(other);
		
		if(other.gameObject.layer != LayerGetter.GROUND_LAYER)
			shaker.intensity = Mathf.Clamp01(other.relativeVelocity.magnitude * intensityFactor);
	}
}
