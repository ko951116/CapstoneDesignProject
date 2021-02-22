using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class VRYesPlease : MonoBehaviour {

	public void Start () {
		StartCoroutine(ActivatorVR ("cardboard"));
	}
	
	public IEnumerator ActivatorVR(string YESVR)
	{
		VRSettings.LoadDeviceByName (YESVR);
		yield return null;
		VRSettings.enabled = true;
	}
}
