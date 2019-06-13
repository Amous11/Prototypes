using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject targetPrefab, target;
	public Transform spawnArea;
	private Vector3 offset, newPos;

	void Update () {
		if (target == null){
			offset = new Vector3(Random.Range(-spawnArea.position.x, spawnArea.position.x), Random.Range(-spawnArea.position.y,spawnArea.position.y), Random.Range(0f,5f));
			newPos = new Vector3(spawnArea.position.x + offset.x, spawnArea.position.y + offset.y, spawnArea.position.z + offset.z);
			target = Instantiate(targetPrefab, newPos, Quaternion.identity);
		}
	}
}
