using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public static int money = 0, notoriety = 0, energy = 12;
	
	private static GameObject player;
	private static Vector3 lastPos;

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
	}

	void Start(){
		player = GameObject.Find("player");
	}

	public static void Mug(){
		if (energy > 0){
			money += 10;
			notoriety++;
			energy--;
			if (notoriety >= 6)
				SceneManager.LoadScene("Busted");
		}
	}
	
	public static void Beg(){
		if (energy > 0){
			money ++;
			energy--;
		}
	}

	public static void StartGH(){
		if (energy > 2){
			energy -= 3;
			SceneManager.LoadScene("GuitarHero");
		}
	}

	public static void LeaveGH(){
		SceneManager.LoadScene("Main");
		money += buttonA.score / 2;
	}

	public static void Buy(){
		if (money >= 5){
			money -= 5;
			energy += 2;
		}
	}

	public static void newDay(){
		
	}
	
}
