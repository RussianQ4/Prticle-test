using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	Transform _transform;
	float _rotatingFactor;
	void Start()
	{
		_transform = transform;
		_rotatingFactor = 0.2f + (Random.value * 0.8f);
	}

	void OnGUI () {
		GUI.Box(new Rect(10,10,100,100) , "sample") ;
		
		if(GUI.Button(new Rect(20,40,80,30) , "Button")) {
			_transform.rotation = _transform.rotation * Quaternion.AngleAxis(Time.deltaTime * 10000 * _rotatingFactor, Vector3.forward);
			}		
	}
}
