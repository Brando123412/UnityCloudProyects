using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HTTPLogin : MonoBehaviour
{
    [SerializeField] public LoginData loginData;
    [SerializeField] public CreateUser createUser;
    [SerializeField] HTTPManagerUnity hTTPManagerUnity;
    [SerializeField] public LoginResponse loginresponse;
    
    private void Awake() {
        hTTPManagerUnity=GetComponent<HTTPManagerUnity>();
    }
    public void AttemptCreateUser()
    {
        StartCoroutine("CreateUser");
    }
    public void AttenLogin(){
        StartCoroutine("Login");
    }
    IEnumerator Login() {
        string json = JsonUtility.ToJson(loginData);

        using(UnityWebRequest www = new UnityWebRequest("https://www.wildcat.games/services/autorpgservices/login.php","POST")){
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
        www.uploadHandler = new UploadHandlerRaw(bodyRaw);
        www.downloadHandler = new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type","application/json");

        yield return www.SendWebRequest();

        if(www.result !=UnityWebRequest.Result.Success){
            Debug.Log(www.error);
        }
        else{
            string responseText = www.downloadHandler.text;
            Debug.Log(responseText);
            loginresponse = JsonUtility.FromJson<LoginResponse>(responseText);
            if(loginresponse.success == "true"){
                hTTPManagerUnity.GoodLogin();
            }else if(loginresponse.success == "false"){
                hTTPManagerUnity.NotLogin();
            }
        }
        }
    }
    IEnumerator CreateUser()
    {
        string json = JsonUtility.ToJson(createUser);

        using (UnityWebRequest www = new UnityWebRequest("https://www.wildcat.games/services/autorpgservices/login.php", "POST"))
        {
            byte[] bodyRaw =System.Text.Encoding.UTF8.GetBytes(json);
            www.uploadHandler = new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();

            if(www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else 
            {
                string responseText = www.downloadHandler.text;
                Debug.Log(responseText);
                loginresponse = JsonUtility.FromJson<LoginResponse>(responseText);
                if(loginresponse.success == "true"){
                    hTTPManagerUnity.GoodCreateCound();
                }else if(loginresponse.success == "false"){
                    hTTPManagerUnity.NotCreateCound();
                }
            }

        }
    }
}
