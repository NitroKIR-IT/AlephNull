using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	public Transform LookAt;
	private bool Lerp = true;
	private float LerpSpeed = 0.1f;//please change manually
	private Vector3 offsets = new Vector3 (0,2, -3);

	private void LateUpdate(){
		Vector3 targetpos = LookAt.transform.position + offsets;

		if (Lerp) {
			transform.position = Vector3.Lerp (transform.position, targetpos, LerpSpeed);
		} else {
			transform.position = targetpos;
		}

	}


}
