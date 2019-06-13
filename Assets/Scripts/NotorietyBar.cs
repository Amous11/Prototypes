﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotorietyBar : MonoBehaviour {

	public Sprite[] sprites;
	private Image image;

	void Start(){
		image = GetComponent<Image>();
	}

	void Update(){
		image.sprite = sprites[GameManager.notoriety];
	}
}