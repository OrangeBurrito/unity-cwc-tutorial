using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour {
	// Start is called before the first frame update
	public AudioSource sound;
	private bool inCooldown;
	private IEnumerator Cooldown() {
		inCooldown = true;
		yield return new WaitForSeconds(1f);
		inCooldown = false;
	}

	void Start() {
		sound = GetComponent<AudioSource>();
	}
	void OnCollisionEnter(Collision target) {
		if (!inCooldown) {
			if (target.gameObject.tag.Equals("Player") == true) {
					sound.Play();
			}
			StartCoroutine(Cooldown());
		}
	}
}
