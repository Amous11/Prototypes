using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRight : MonoBehaviour {

	public bool isCollided;
    public Collider2D colidifier;

    public Sprite[] sprites;
	// Use this for initialization

    private GameObject mainProjectile;
    public GameObject particlePrefab;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GetComponent<SpriteRenderer> ().sprite = sprites [1];
			if (isCollided) {
				Destroy (colidifier.gameObject);
				mainProjectile = Instantiate (particlePrefab, transform.position + new Vector3 (0, 0, 1), Quaternion.identity);
				buttonA.score++;
				print (" Life : " + buttonA.life + " Score : " + buttonA.score);
			} else {
				buttonA.life--;
				print (" Life : " + buttonA.life + " Score : " + buttonA.score);

			}

			print ("space key was pressed");
		} else if (Input.GetKeyUp (KeyCode.RightArrow)) {
			GetComponent<SpriteRenderer> ().sprite = sprites [0];

		} /*else {
			if (isCollided) {
				buttonA.life--;
				print (" Life : " + buttonA.life + " Score : " + buttonA.score);

			}
	}*/
		
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
        isCollided = false;
        colidifier = null;
    }
}
