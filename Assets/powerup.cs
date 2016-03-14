using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

	void Start () {
		GetComponent<MeshRenderer> ().enabled = true;
	}

	void OnTriggerEnter () {
		GetComponent<MeshRenderer> ().enabled = false;
		HoverCarControl.powerup += 0.05f;
	}
}