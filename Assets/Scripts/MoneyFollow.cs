using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyFollow : MonoBehaviour {
	
	bool approched = false;
	public GameObject moneyui;
	public float speed = 10;
	
	// Update is called once per frame
	void Update () {
		if(!approched){
			Vector2 direction = moneyui.transform.position - transform.position;
			transform.Translate (direction * speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "MoneyUi") {
			approched = true;
			Destroy (gameObject);
			print ("moneyobject");
		}
	}
}