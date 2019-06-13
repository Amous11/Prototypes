using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonA : MonoBehaviour {
    public bool isCollided;
    public Collider2D colidifier;
    public Sprite[] sprites;
	public static int score = 0;
	public static int life = 6;
    private GameObject mainProjectile;
    public GameObject particlePrefab;
	public int test = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            
			GetComponent<SpriteRenderer> ().sprite = sprites [1];

            
            


			if (isCollided) {
				Destroy (colidifier.gameObject);
				mainProjectile = Instantiate (particlePrefab, transform.position + new Vector3 (0, 0, 1), Quaternion.identity);
				score++;
			} else {
				life--;
				print (" Life : " + buttonA.life + " Score : " + buttonA.score);

			}
            
		} else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			GetComponent<SpriteRenderer> ().sprite = sprites [0];

		} 


	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "RedBloc")
        {
            print("OBJECT OnTriggerEnter2D");
            isCollided = true;
            colidifier = col;
                
         }
    }
    void OnTriggerExit2D(Collider2D col)
    {
		Destroy (colidifier.gameObject);

        isCollided = false;
        colidifier = null;
		print("OnTriggerExit2D --- ");

    }
}
