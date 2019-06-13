using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public Transform target;
	public GameObject coinPrefab;

	private float speed = 2f;
	//private Vector3 direction;
	private GameObject coin;
	private bool arrived = false;
	private Vector3 targetPos;

	// Use this for initialization
	void Start () {
		targetPos = target.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.LeftArrow))
			coin = Instantiate(coinPrefab, transform.position + new Vector3(0,0,-1) , Quaternion.identity);	

		Vector3 coinPos = coin.transform.position;
		Vector3 direction = targetPos - coinPos;
		if (!arrived){
			coin.transform.Translate(direction * speed * Time.deltaTime);
		}
		else {
			Destroy(coin);
			arrived = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "MoneyUi")
			arrived = true;
	}
}
