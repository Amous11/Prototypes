using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pplScript : MonoBehaviour {
	public float speed=10;
	public GameObject hobo;
	private bool approached;
	// Use this for initialization
	public Animator animator;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!approached){
			Vector2 direction = hobo.transform.position - transform.position;
			transform.Translate(direction*speed*Time.deltaTime);
			animator.enabled = true;
		}
	}
	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.tag == "Wall"){
			approached = true;
			Debug.Log("test");	
		}
	}
}
