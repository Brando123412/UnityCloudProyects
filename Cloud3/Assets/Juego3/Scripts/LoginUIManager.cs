using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUIManager : MonoBehaviour
{
    public InputField userFiel;
    public InputField passwordFiel;
    HTTPLogin login;
    
    private void Awake() {
        login = FindAnyObjectByType<HTTPLogin>();
    }

    public void SetUserInputText(string text){
        login.loginData.username=text;
    }
    public void SetPassInputText(string text){
        login.loginData.password=text;
    }
    public void Login(){
        login.AttenLogin();
    }
}
