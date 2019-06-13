using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 2f;
	public GameObject shopUI, homeUI;

	// Update is called once per frame
	void Update () {
		Vector2 lastPos = transform.position;
		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);

		if (lastPos.x - transform.position.x < 0f)
			GetComponent<SpriteRenderer>().flipX = false;
		else if (lastPos.x - transform.position.x > 0f)
			GetComponent<SpriteRenderer>().flipX = true;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.name == "guitar")
			GameManager.StartGH();

		if (other.transform.name == "shop"){
			shopUI.SetActive(true);
		}

		if (other.transform.name == "hobo_house")
			GameManager.newDay();

		if (other.transform.name == "home")
			homeUI.SetActive(true);
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.transform.name == "home")
			homeUI.SetActive(false);

		if (other.transform.name == "shop")
			shopUI.SetActive(false);
	}
}
