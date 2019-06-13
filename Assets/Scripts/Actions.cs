using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Actions : MonoBehaviour {

		public Button mug;
		public Button beg;

		void Start(){
			mug = transform.Find("Mug").GetComponent<Button>();
			beg = transform.Find("Beg").GetComponent<Button>();
			mug.onClick.AddListener(Mugging);
			beg.onClick.AddListener(Begging);
		} 

		void Mugging(){
			GameManager.Mug();
		}

		void Begging(){
			Debug.Log("You begged");
			GameManager.money += 1;
			GameManager.energy -= 1;
		}
}
