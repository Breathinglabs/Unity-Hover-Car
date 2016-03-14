
static var playerTransform : Transform; //Store the player transform

function Start () {
	playerTransform = gameObject.Find("HoverCar").transform; //Set the player transform
}

function OnTriggerEnter (other : Collider) {
	//Is it the Player who enters the collider?
	if (!other.CompareTag("HoverCar")) 
		return; //If it's not the player dont continue
		
	//Is this transform equal to the transform of checkpointArrays[currentCheckpoint]?
	if (transform == playerTransform.GetComponent(CarCheckpoint).checkPointArray[CarCheckpoint.currentCheckpoint].transform) {
		//Check so we dont exceed our checkpoint quantity
		if (CarCheckpoint.currentCheckpoint + 1<playerTransform.GetComponent(CarCheckpoint).checkPointArray.length) {
			//Add to currentLap if currentCheckpoint is 0
			if(CarCheckpoint.currentCheckpoint == 0)
				CarCheckpoint.currentLap++;
			CarCheckpoint.currentCheckpoint++;
		} else {
			//If we dont have any Checkpoints left, go back to 0
			CarCheckpoint.currentCheckpoint = 0;
		}
		visualAid(); //Run a coroutine to update the visual aid of our Checkpoints
		//Update the 3dtext
		Camera.main.GetComponentInChildren(TextMesh).text = "Checkpoint: "+(CarCheckpoint.currentCheckpoint)+" Lap: "+(CarCheckpoint.currentLap);
	}
}

function visualAid () {
	//Set a simple visual aid for the Checkpoints
	for (objAlpha in playerTransform.GetComponent(CarCheckpoint).checkPointArray) {
		objAlpha.GetComponent.<Renderer>().material.color.a = 0.2;
	}
	playerTransform.GetComponent(CarCheckpoint).checkPointArray[CarCheckpoint.currentCheckpoint].GetComponent.<Renderer>().material.color.a = 0.8;
}