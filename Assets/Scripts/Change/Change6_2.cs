using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Change6_2 : MonoBehaviour
{

    private bool gazedAt = false;
    private float gazedTime = 2.0f;
    private float timer = 0.0f;
    private Image image = null;

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
                SceneManager.LoadScene("6.2");//1초가 넘어갔을때 씬을 
                timer = 0.0f; //타이머 초기화
            }
        }
        else
        {
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
