using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptCD : MonoBehaviour {

	private float c=0;
	public Text countdown;
	private int k;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			c += Time.deltaTime;
		if (c >-0.1f && c<3.1f) {
			k = (int)Mathf.Round (c);
			print (k);
			countdown.text = k.ToString ();
	}
		else {countdown.text = "";}
	}
}
