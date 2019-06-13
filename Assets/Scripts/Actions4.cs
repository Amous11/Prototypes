using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions4 : MonoBehaviour {

	private Button exit;
	
	// Use this for initialization
	void Start () {
		exit = GetComponent<Button>();
		exit.onClick.AddListener(Exit);
	}
	
	// Update is called once per frame
	void Exit () {
		GameObject.Find("ShopUI").SetActive(false);
	}
}
