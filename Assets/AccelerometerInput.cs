using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {
	public float speed = 10F;
	void Update() {
		float temp = Input.acceleration.x;
		Debug.Log (temp);
		transform.Rotate (0, temp * speed, 0);


	}
}