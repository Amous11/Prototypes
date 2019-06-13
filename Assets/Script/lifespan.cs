using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifespan : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (GetComponent<ParticleSystem>().IsAlive() == false)
			Destroy(gameObject);		
	}
}
