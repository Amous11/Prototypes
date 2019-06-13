using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSprites : MonoBehaviour {

	public Sprite[] sprites;
	private SpriteRenderer spriteRenderer;

	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = sprites[(int)Random.Range(0f,6f)];
	}
}
