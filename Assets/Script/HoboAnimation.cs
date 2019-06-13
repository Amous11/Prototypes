using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoboAnimation : MonoBehaviour {

	public int rate;
	private int frameCount;

	public GameObject[] notes;
	public GameObject[] ppl;
	public GameObject spawnOne;
	public GameObject spawnTwo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		frameCount++;
		if(frameCount>rate){
		int x = (int)Random.Range(0,notes.Length-1);
		int pplX = (int)Random.Range(0,ppl.Length-1);
		float pplSpawnsX = Random.Range(spawnOne.transform.position.x, spawnTwo.transform.position.x);
		
		Instantiate(ppl[pplX],new Vector3(pplSpawnsX, spawnOne.transform.position.y, -1f), Quaternion.identity);
		//Random.Range(transform.position.x-xD,transform.position.x+xF)
		Instantiate(notes[x], transform.position + new Vector3(Random.Range(-1,1),0,-1), Quaternion.identity);
				

		frameCount=0;
		}
		
	}
}
