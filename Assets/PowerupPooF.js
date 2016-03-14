#pragma strict

var poof : GameObject;

function Start (){
	poof.SetActive(false);
}

function OnTriggerEnter() {
	poof.SetActive(true);
}
function OnTriggerExit() {
	poof.SetActive(false);
}