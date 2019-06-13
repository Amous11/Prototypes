using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions2 : MonoBehaviour {

	private Button back;

	// Use this for initialization
	void Start () {
		back = GetComponent<Button>();
		back.onClick.AddListener(backToGame);
	}

	void backToGame(){
		GameManager.LeaveGH();
		scriptUp.gameEnded = false;
		buttonA.life = 6;
	}
}
