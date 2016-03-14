using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class taptostart : MonoBehaviour {
	
	void Awake () {
		Time.timeScale = 0;
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Time.timeScale = 1;
			gameObject.GetComponent<Text>().text=""; 
		}
	}
}
