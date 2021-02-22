using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Number : MonoBehaviour {

	private bool gazedAt = false;
	private float gazedTime = 1.0f;
	private float timer = 0.0f;
	private Image image = null;

	public GameObject WarningTextObj;
	public GameObject WarningTextObj2;
	public GameObject WarningTextObj3;
    

	// Use this for initialization
	void Start()
	{
		image = GetComponent<Image>();

	}
	void Update()
	{
		if (gazedAt)
		{
			timer += Time.deltaTime;

			if (timer >= 1.0f)
			{
				WarningTextObj.SetActive(true);
				WarningTextObj2.SetActive(true);
				WarningTextObj3.SetActive(true);
                timer = 0.0f; //타이머 초기화
            }
		}
		else
		{
			WarningTextObj.SetActive(false);
			WarningTextObj2.SetActive(false);
			WarningTextObj3.SetActive(false);

			//OriginTextObj.SetActive(true);
			timer = 0.0f;
		}
		// image.value = timer / gazedTime; //value:0~1사이값
	}

	public void PointerEnter()
	{
		gazedAt = true;
	}

	public void PointerExit()
	{
        gazedAt = false;

	}
}
