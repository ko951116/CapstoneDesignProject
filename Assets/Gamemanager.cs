using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour {

    [Header("LoginPanel")]
    public InputField IDInputField;
    public InputField PassInputField;
    [Header("CreateAccountPanel")]
    public InputField New_IDInputField;
    public InputField New_PassInputField;
    public GameObject CreateAccountPanelObj;

    public string LoginUrl;
    public string CreateUrl;
    // Use this for initialization
    void Start () {

        LoginUrl = "kos2399.cafe24.com/Login.php";
        CreateUrl = "kos2399.cafe24.com/CreateAccount.php";

    }


    public void LoginBtn()
    {

        StartCoroutine(LoginCo());
    }

    IEnumerator LoginCo()
    {
        Debug.Log(IDInputField.text);
        Debug.Log(PassInputField.text);

        WWWForm form = new WWWForm();
        form.AddField("Input_user", IDInputField.text);
        form.AddField("Input_pass", PassInputField.text);

        // 예)
        // form.AddField("Input_Position", "(0,0,0)");
        // form.AddField("Input_ITem", "검입니다. !");
        WWW webRequest = new WWW(LoginUrl, form);
        yield return webRequest;

        Debug.Log(webRequest.text);


    }


    public void OpenCreateAccountBtn()
    {

        CreateAccountPanelObj.SetActive(true);
     //  
    }


    public void CreateAccountBtn()
    {
        StartCoroutine(CreateCo());

    }

    IEnumerator CreateCo()
    {
     

        WWWForm form = new WWWForm();
        form.AddField("Input_user", New_IDInputField.text);
        form.AddField("Input_pass", New_PassInputField.text);
        form.AddField("Input_Info", "안녕하세요 뉴비입니다.");
        // 예)
        // form.AddField("Input_Position", "(0,0,0)");
        // form.AddField("Input_ITem", "검입니다. !");
        WWW webRequest = new WWW(CreateUrl, form);
        yield return webRequest;

        Debug.Log(webRequest.text);



        yield return null;
    }

}
