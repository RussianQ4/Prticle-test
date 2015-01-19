using UnityEngine;
using System.Collections;

public class unit1_attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localPosition = new Vector3(1.0f, 1.5f, 2.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
		// x *= 3
		// y *= 3
		// z *= 3
		transform.position *= 3;
		
		// x /= 3
		// y /= 3
		// z /= 3
		transform.eulerAngles /= 3;
	}
}
