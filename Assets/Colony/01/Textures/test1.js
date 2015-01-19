var startFlag : boolean;

function Update () {
	if (startFlag) {
		var toRot : Quaternion = Quaternion.Euler(0, 0, -90);
		transform.rotation = Quaternion.Slerp (transform.rotation, toRot, Time.deltaTime * 1.5);
	}
}

function OnGUI () {
	var fromRot;
	var toRot;
	if (GUI.Button (Rect(5, 5, 150, 40), "グラビティチェンジ")) {
		startFlag = true;
	}
	if (GUI.Button (Rect(5, 140, 150, 40), "リセット")) {
		startFlag = false;
		transform.rotation = Quaternion.Euler(0, 0, 0);
	}
	GUI.Label (Rect(5, Screen.height-20, 150, 20), "Rotation.Y = "+transform.rotation.eulerAngles.y);
}