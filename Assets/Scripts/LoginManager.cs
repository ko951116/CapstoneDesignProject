using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour {

    [Header("LoginPanel")]
    public InputField IDInputField;
    public InputField PWInputField;
    [Header("CreateAccountPanel")]
    public InputField NewIDInputField;
    public InputField NewPWInputField;
    public GameObject CreateAccountPanelObj;
    public GameObject BeforeMainPanelObj;

    public string LoginUrl;
    public string CreateUrl;

    // Use this for initialization
    void Start()
    {

        LoginUrl = "http://nplusy0624.cafe24.com/Login.php";
        CreateUrl = "http://nplusy0624.cafe24.com/CreateAccount.php";

    }


    public void LoginBtn()
    {

        StartCoroutine(LoginCo());
    }

    IEnumerator LoginCo()
    {
        Debug.Log(IDInputField.text);
        Debug.Log(PWInputField.text);

        WWWForm form = new WWWForm();
        form.AddField("Input_user", IDInputField.text);
        form.AddField("Input_pass", PWInputField.text);

        // 예)
        // form.AddField("Input_Position", "(0,0,0)");
        // form.AddField("Input_ITem", "검입니다. !");
        WWW webRequest = new WWW(LoginUrl, form);
        yield return webRequest;

        if ((!string.IsNullOrEmpty(webRequest.error)))
        {
            print("Error: " + webRequest.error);
        }

        if (webRequest.text =="'환영합니다' \nLogin-Success!!")
            BeforeMainPanelObj.SetActive(true);
        else
            Debug.Log(webRequest.text);

        yield return null;


    }


    public void OpenCreateAccountBtn()
    {

        CreateAccountPanelObj.SetActive(true);
        
    }
    

    public void CreateAccountBtn()
    {
        StartCoroutine(CreateCo());
        CreateAccountPanelObj.SetActive(false);

    }

    IEnumerator CreateCo()
    {

        Debug.Log(NewIDInputField.text);
        Debug.Log(NewPWInputField.text);

        WWWForm form = new WWWForm();
        form.AddField("Input_user", NewIDInputField.text);
        form.AddField("Input_pass", NewPWInputField.text);
        form.AddField("Input_Info", "환영합니다");
        // 예)
        // form.AddField("Input_Position", "(0,0,0)");
        // form.AddField("Input_ITem", "검입니다. !");
        WWW webRequest = new WWW(CreateUrl, form);
        yield return webRequest;

        if ((!string.IsNullOrEmpty(webRequest.error)))
        {
            print("Error: " + webRequest.error);
        }

        Debug.Log(webRequest.text);

        yield return null;
    }

    public void YesBtn()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void NoBtn()
    {
        BeforeMainPanelObj.SetActive(false);

    }
}
