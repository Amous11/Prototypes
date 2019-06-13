using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggro : MonoBehaviour {

	//sets the focus on this if not already on focus
	//closing the menu or leaving aggro loses focus
	//need game manager to handle focus

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.name == "player"){
			transform.parent.gameObject.transform.GetChild(1).gameObject.SetActive(true);
		}
			
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.transform.name == "player")
			transform.parent.gameObject.transform.GetChild(1).gameObject.SetActive(false);
			Destroy(transform.parent.GetChild(1).GetComponent<NpcMenu>().menu.gameObject);
			transform.parent.GetChild(1).GetComponent<NpcMenu>().instantiated = false;
	}
}
