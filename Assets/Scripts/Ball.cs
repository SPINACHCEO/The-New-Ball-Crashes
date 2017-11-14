using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float maxAngularSpeed;
	public float torque;

	public float pushForce = 1;
	
	private Rigidbody r_body;
	
	// Use this for initialization
	void Start () {
		r_body = GetComponent<Rigidbody>();

		r_body.maxAngularVelocity = maxAngularSpeed;
	}

	private void FixedUpdate() {
		//Debug.Log(r_body.velocity.sqrMagnitude);
	}

	public void SetMovement(float x, float z) {
		r_body.AddTorque(new Vector3(x,0,z) * torque);
	}

	public virtual void OnCollisionEnter(Collision other) {
//		if (other.gameObject.layer != LayerGetter.GROUND_LAYER) {
//			var v = r_body.velocity;
//			v.y = 0;
//			v = v.normalized * r_body.velocity.magnitude * pushForce;
//		
//			other.rigidbody.AddForce(v);
//		}
	}
}
