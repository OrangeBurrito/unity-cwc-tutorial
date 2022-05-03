using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public GameObject player;
	private Vector3 offset = new Vector3(0, 5, -7);
	private bool firstPersonMode = false;
	void Start() {

	}

	void Update() {
	}

	void LateUpdate() {
		if (Input.GetKeyDown(KeyCode.Y)) {
			SwitchCameraView(ref offset, ref firstPersonMode);
		}

		transform.position = player.transform.position + offset;
	}

	private void SwitchCameraView(ref Vector3 offset, ref bool firstPersonMode) {
		if (firstPersonMode == false) {
			offset = new Vector3(0, 3, 0);
			firstPersonMode = true;
		} else if (firstPersonMode == true) {
			offset = new Vector3(0, 5, -7);
			firstPersonMode = false;
		}
	}
}
