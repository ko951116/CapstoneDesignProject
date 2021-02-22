using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class VRNoThanks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (DeactivatorVR ("none"));
	}

	public IEnumerator DeactivatorVR(string NOVR)
	{
		VRSettings.LoadDeviceByName (NOVR);
		yield return null;
		VRSettings.enabled = false;

	}

}
