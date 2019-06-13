using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour {
	public bool inHand, unstretchedPos, stretchedPos, onSlider;
	public GameObject arrowPrefab;
	private GameObject child;
	void Start(){
		inHand = false;
		stretchedPos = false;
		unstretchedPos = false;
	}

	void Update(){

		if (GetComponent<SteamVR_TrackedController>().triggerPressed && !inHand){
			child = Instantiate(arrowPrefab, transform.position, transform.rotation, this.transform);
			inHand = true;
		}
		else if (GetComponent<SteamVR_TrackedController>().padPressed && inHand){
			DestroyImmediate(child);
			inHand = false;
		}
	}

	void OnTriggerEnter(Collider other){
		if ((other.name == "Tip") && (!inHand))
			unstretchedPos = true;
		if ((other.name == "Base") && (unstretchedPos))
			stretchedPos = true;
		if (other.name == "Slider")
			onSlider = true;
	}

	void OnTriggerExit(Collider other){
		if (other.name == "Slider")
			onSlider = false;
	}
}
