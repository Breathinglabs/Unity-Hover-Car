#pragma strict

var smoke : GameObject;

function Start (){
	smoke.SetActive(false);
}

function OnTriggerEnter() {
	smoke.SetActive(true);
}