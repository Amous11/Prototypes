using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision other){
		if (other.transform.tag == "Arrow"){
			Destroy(transform);
		}
	}
}
