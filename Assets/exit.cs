using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
	}
}
