using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartUi : MonoBehaviour {
	
	private Image spriteR;
	public Sprite[] tSprite;
	
	// Update is called once per frame
	void Update () {
		if (buttonA.life > 0 && buttonA.life < 7) {
			spriteR = gameObject.GetComponent<Image>();
			spriteR.sprite = tSprite [buttonA.life];
		}

	}
}
