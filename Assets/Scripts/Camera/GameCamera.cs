using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour {

	public Transform target;

	private void LateUpdate() {
		transform.position = target.position;
	}
}
