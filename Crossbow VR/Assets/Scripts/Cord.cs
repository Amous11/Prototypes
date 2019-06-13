using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cord : MonoBehaviour {

	public GameObject start, controllerLeft, controllerRight;
	public bool stretched;
	private bool unstretchedPos, stretchedPos;
	private float stretch;
	private SkinnedMeshRenderer blendShape;
	private SteamVR_Controller.Device deviceLeft, deviceRight;
	private SteamVR_TrackedObject trackedObjRight, trackedObjLeft;
	[SerializeField] private ushort vibration;
	void Start(){
		vibration = 20;
		stretched = false;
		blendShape = GetComponent<SkinnedMeshRenderer>();
		trackedObjRight = controllerRight.GetComponent<SteamVR_TrackedObject>();
		trackedObjLeft = controllerLeft.GetComponent<SteamVR_TrackedObject>();
	}

	void Update(){
		deviceLeft = SteamVR_Controller.Input((int)trackedObjLeft.index);
		deviceRight = SteamVR_Controller.Input((int)trackedObjRight.index);

		unstretchedPos = controllerLeft.GetComponent<Picker>().unstretchedPos;
		stretchedPos = controllerLeft.GetComponent<Picker>().stretchedPos;

		if ((unstretchedPos && !stretchedPos) && (!controllerLeft.GetComponent<Picker>().inHand) && (!stretched) && (controllerLeft.GetComponent<Picker>().onSlider)){
			stretch = Vector3.Distance(controllerLeft.transform.Find("Detector").position, start.transform.position);
			blendShape.SetBlendShapeWeight(0, stretch * 500);
			deviceLeft.TriggerHapticPulse((ushort)(blendShape.GetBlendShapeWeight(0) * vibration));
			deviceRight.TriggerHapticPulse((ushort)(blendShape.GetBlendShapeWeight(0) * vibration));
		}
		else if ((unstretchedPos && stretchedPos) && (!controllerLeft.GetComponent<Picker>().inHand) && (!stretched)){
			controllerLeft.GetComponent<Picker>().unstretchedPos = false;
			controllerLeft.GetComponent<Picker>().stretchedPos = false;
			blendShape.SetBlendShapeWeight(0, 100f);
			stretched = true;
		}

		if ((!controllerLeft.GetComponent<Picker>().onSlider) && (!stretched))
			blendShape.SetBlendShapeWeight(0, 0f);
	}
}
