using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions3 : MonoBehaviour {

	private Button buy;

	// Use this for initialization
	void Start () {
		buy = GetComponent<Button>();
		buy.onClick.AddListener(buyThings);
	}

	void buyThings(){
		GameManager.Buy();
	}
}
