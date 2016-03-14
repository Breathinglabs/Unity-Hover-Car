using UnityEngine;
using System.Collections;

public class CS_binaryDetection_1 : MonoBehaviour {

	public GameObject micController;
	private float getLoudness;

	void Start () {
		GetComponent<SpriteRenderer> ().enabled = false;
	}

	void Update () {

		getLoudness = micController.GetComponent<MicControl> ().loudness;

		if (getLoudness > 0.1) {
			GetComponent<SpriteRenderer> ().enabled = true;
		}
		
		if (getLoudness < 0.1) {
			GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}