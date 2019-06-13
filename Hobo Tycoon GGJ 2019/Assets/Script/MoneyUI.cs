using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour {

	private Text printedMoney;
	
	void Start(){
		printedMoney = GetComponent<Text>();
	}
	
	void Update () {
		printedMoney.text = GameManager.money.ToString();	
	}
}
