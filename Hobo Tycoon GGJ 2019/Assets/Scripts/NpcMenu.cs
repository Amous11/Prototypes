using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcMenu : MonoBehaviour {

	public Transform canvas;
	public GameObject menuPrefab;
	public GameObject menu;

	public bool instantiated;
	
	void Start(){
		canvas = GameObject.Find("Canvas").transform;
		instantiated = false;
	}

	// Update is called once per frame
	void Update () {
		
		if (!instantiated && menu == null){
			menu = Instantiate(menuPrefab, canvas.position, Quaternion.identity);
			menu.transform.SetParent(canvas);
			instantiated = true;
		}

		Vector2 menuPos = Camera.main.WorldToScreenPoint(this.transform.position);
		menu.transform.position = menuPos;
	}
}
