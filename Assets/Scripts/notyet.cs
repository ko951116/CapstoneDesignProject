using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class notyet : MonoBehaviour {

    private bool gazedAt = false;
    private float gazedTime = 2.0f;
    private float timer = 0.0f;
    private Image image = null;

    public GameObject WarningTextObj;
    public GameObject OriginTextObj;

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

            if (timer >= 2.0f)
            {
                
                timer = 0.0f; //타이머 초기화
                WarningTextObj.SetActive(true);
                OriginTextObj.SetActive(false);
            }
        }
        else
        {
            WarningTextObj.SetActive(false);
            //OriginTextObj.SetActive(true);
            timer = 0.0f;
        }
        // image.value = timer / gazedTime; //value:0~1사이값
    }

    public void PointerEnter()
    {
        OriginTextObj.SetActive(true);
        gazedAt = true;
    }

    public void PointerExit()
    {
        gazedAt = false;
        OriginTextObj.SetActive(false);

    }
}
