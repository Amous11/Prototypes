using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {

	public GameObject bow, gameManager, cord;
	private FireBolt fireBolt;
	private Transform parent;
	void Start(){
		bow = GameObject.Find("Body");
		fireBolt = bow.GetComponent<FireBolt>();
		parent = fireBolt.transform;
		gameManager = GameObject.Find("GameManager");
		cord = GameObject.Find("Cord");
	}

	void OnTriggerEnter(Collider other){
		if ((other.tag == "Spawn") && (fireBolt.charged == false) && (cord.GetComponent<Cord>().stretched)){
			transform.parent.GetComponent<Picker>().inHand = false;
			fireBolt.charged = true;
			fireBolt.projectile = Instantiate(fireBolt.projectilePrefab, other.transform.position, fireBolt.transform.rotation, parent);
			Destroy(transform.gameObject, 0f);
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.transform.tag == "Target"){
			Destroy(other.gameObject);
			gameManager.GetComponent<GameManager>().target = null;
			Destroy(transform.gameObject);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Spawn"){
			fireBolt.charged = false;
		}
	}

}
