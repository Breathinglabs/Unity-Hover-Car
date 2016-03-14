using UnityEngine;
using System.Collections;

public class CS_loudnessDetection : MonoBehaviour {

	public GameObject micController;
	private float getLoudness;

	void Update () {

		getLoudness = micController.GetComponent<MicControl> ().loudness;
		
		transform.localScale = new Vector3 (1+getLoudness,1+getLoudness,1+getLoudness);
	}
}