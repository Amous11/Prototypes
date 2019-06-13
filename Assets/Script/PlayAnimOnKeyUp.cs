using UnityEngine;
using System.Collections;

public class PlayAnimOnKeyUp : MonoBehaviour {

    public GameObject mainProjectile;
    public ParticleSystem mainParticleSystem;

    public GameObject particlePrefab;
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            mainProjectile = Instantiate(particlePrefab, transform.position, Quaternion.identity);
        }

        if (mainParticleSystem.IsAlive() == false)
            mainProjectile.SetActive(false);
	
	}
}
