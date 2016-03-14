using UnityEngine;
using System.Collections;

public class CS_binaryDetection_0 : MonoBehaviour {

	public GameObject micController;
	private float getLoudness;

	void Start () {
		GetComponent<SpriteRenderer> ().enabled = true;
	}

	void Update () {

		getLoudness = micController.GetComponent<MicControl> ().loudness;

		if (getLoudness > 0.1) {
			GetComponent<SpriteRenderer> ().enabled = false;
		}
		
		if (getLoudness < 0.1) {
			GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}