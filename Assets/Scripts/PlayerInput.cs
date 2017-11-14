using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	public Ball targetPlayer;
	
	private void FixedUpdate() {
		var h = Input.GetAxis("Horizontal");
		var v = Input.GetAxis("Vertical");
		
		targetPlayer.SetMovement(h,v);
	}
}
