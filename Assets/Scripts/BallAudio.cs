using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAudio : MonoBehaviour {

	public AudioSource impactSource;
	public float impactVolumesFactor;

	private void OnCollisionEnter(Collision other) {
		if(other.gameObject.layer == LayerGetter.GROUND_LAYER) return;

		if (impactSource) {
			impactSource.volume = other.relativeVelocity.magnitude * impactVolumesFactor;
			impactSource.Play();
		}
	}
}
