using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeBtnA : MonoBehaviour {
	public bool isCollided;
	public Collider2D colidifier;
	public Sprite[] sprites;
	public static int score = 0;
	private GameObject mainProjectile;
	public GameObject particlePrefab;
	public int test = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (scriptUp.gameEnded==true) {
			SceneManager.LoadScene ("ScoreScene");	}
		}




	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "RedBloc")
		{
			buttonA.life--;
			print ("Life " + buttonA.life);
			print("OBJECT OnTriggerEnter2D");
			isCollided = true;
			colidifier = col;
			Destroy (colidifier.gameObject);

		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		
		isCollided = false;
		colidifier = null;

	}
}
