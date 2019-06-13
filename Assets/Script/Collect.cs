using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	public static  int cansCollected = 0;
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "player"){
			Destroy (this.gameObject);
			GameManager.money += 3;
		}
	}

}
