using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDown : MonoBehaviour {

	public bool isCollided;
    public Sprite[] sprites;
    public Collider2D colidifier;
	public buttonA vars;
    private GameObject mainProjectile;
    public GameObject particlePrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GetComponent<SpriteRenderer> ().sprite = sprites [1];
			if (isCollided) {
				Destroy (colidifier.gameObject);
				mainProjectile = Instantiate (particlePrefab, transform.position + new Vector3 (0, 0, 1), Quaternion.identity);
			} else {
				buttonA.life--;
				print (" Life : " + buttonA.life + " Score : " + buttonA.score);

			}

			print ("space key was pressed");
		} else if (Input.GetKeyUp (KeyCode.DownArrow)) {
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
