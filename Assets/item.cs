using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnBecameInvisible() {
		Debug.Log (gameObject.name);
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
