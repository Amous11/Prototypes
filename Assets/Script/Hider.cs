using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hider : MonoBehaviour {

	private SpriteRenderer player;

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.name == "player")
			other.GetComponent<SpriteRenderer>().enabled = false;
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.transform.name == "player")
			other.GetComponent<SpriteRenderer>().enabled = true;
	}
}
