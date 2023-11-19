using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateUserUIManager : MonoBehaviour
{
    public InputField name;
    public InputField lastname;
    public InputField sex;
    public InputField address;
    public InputField dni;
    public InputField cellphone;
    public InputField username;
    public InputField password;
    HTTPLogin create;

    private void Awake() {
        create = FindAnyObjectByType<HTTPLogin>();
    }
    public void SetNameInputText(string text){
        create.createUser.name=text;
    }
    public void SetLastnameInputText(string text){
        create.createUser.lastname=text;
    }
    public void SetSexInputText(string text){
        create.createUser.sex=text;
    }
    public void SetAddressInputText(string text){
        create.createUser.address=text;
    }
    public void SetDniInputText(string text){
        create.createUser.dni=text;
    }
    public void SetCellphoneInputText(string text){
        create.createUser.cellphone=text;
    }
    public void SetUserNamephoneInputText(string text){
        create.createUser.username=text;
    }
    public void SetPasswordphoneInputText(string text){
        create.createUser.password=text;
    }
    public void CreateButton(){
        create.AttemptCreateUser();
    }
    
}
