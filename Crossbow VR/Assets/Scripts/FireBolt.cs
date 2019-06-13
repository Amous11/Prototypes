using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBolt : MonoBehaviour {

	public bool charged, fire, hold;
	public float projectileVelocity;
	public GameObject projectilePrefab, rCtr, lCtr, projectile, cord;
	private bool reload;
	private SteamVR_Controller.Device device;
	private SteamVR_TrackedObject trackedObj;
	private int childNumber;
	private AudioClip audioClip;
	void Start () {
		projectileVelocity = 30.0f;
		charged = false;
		trackedObj = rCtr.GetComponent<SteamVR_TrackedObject>();
		childNumber = transform.childCount;
		audioClip = GetComponent<AudioSource>().clip;
	}
	
	void Update () {
		fire = rCtr.GetComponent<SteamVR_TrackedController>().triggerPressed;
		hold = lCtr.GetComponent<SteamVR_TrackedController>().triggerPressed;
		device = SteamVR_Controller.Input((int)trackedObj.index);

		if ((!charged) && (transform.childCount > childNumber))
			Destroy(transform.GetChild(childNumber).gameObject);

		if(fire && charged)
			Fire();
		else if (fire && !charged)
			Debug.Log("Needs to Reload");
	}

	void Fire(){
		projectile.transform.parent = null;
		projectile.GetComponent<Rigidbody>().velocity = projectile.transform.forward * projectileVelocity;
		projectile.GetComponent<Rigidbody>().useGravity = true;
		projectile.GetComponent<Rigidbody>().isKinematic = false;
		projectile.GetComponent<TrailRenderer>().enabled = true;
		GetComponent<AudioSource>().PlayOneShot(audioClip);
		Destroy(projectile, 5.0f);
		StartCoroutine("ResetCord");
		StartCoroutine("Vibrate");
	}

	IEnumerator ResetCord(){
		for (float blend = 100f; blend >= 0; blend -= 50f){
			cord.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, blend);
			if (cord.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(0) == 0){
				cord.GetComponent<Cord>().stretched = false;
				lCtr.GetComponent<Picker>().unstretchedPos = false;
				lCtr.GetComponent<Picker>().stretchedPos = false;
			}
			yield return null;
		}
	}

	IEnumerator Vibrate(){
		for (float time = 0; time < 0.1f; time += Time.deltaTime){
			device.TriggerHapticPulse(4000);
			yield return null;
		}
	}
}
