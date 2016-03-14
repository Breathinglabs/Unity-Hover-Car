using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class taptostartimage : MonoBehaviour {
	
	void Awake () {
		GetComponent<Image> ().enabled = true;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Image> ().enabled = false; 
		}
	}
}
