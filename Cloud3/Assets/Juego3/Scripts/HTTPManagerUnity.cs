using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HTTPManagerUnity : MonoBehaviour
{
    [SerializeField] Image verificCreateCound;
    [SerializeField] Image verificlogin;
    [SerializeField] GameObject panelReferences;
    [SerializeField] Sprite[] imagesCorrect;
    private void Awake() {
        verificCreateCound.color = new Color(0,0,0,0);
        verificlogin.color = new Color(0,0,0,0);
    }
    public void GoodCreateCound(){
        verificCreateCound.color = new Color(1,1,1,1);
        verificCreateCound.sprite = imagesCorrect[0];
        print("createGood");
        Invoke("ActivePanel",4);
    }
    public void NotCreateCound(){
        verificCreateCound.color = new Color(1,1,1,1);
        verificCreateCound.sprite = imagesCorrect[1];
        print("CreateNever");
        Invoke("NotCreate",4);
    }
    void ActivePanel(){
        verificCreateCound.color = new Color(0,0,0,0);
        panelReferences.SetActive(false);
    }
    void NotCreate(){
        verificCreateCound.color = new Color(0,0,0,0);
    }
    public void GoodLogin(){
        verificlogin.color = new Color(1,1,1,1);
        verificlogin.sprite = imagesCorrect[0];
    }
    public void NotLogin(){
        verificlogin.color = new Color(1,1,1,1);
        verificlogin.sprite = imagesCorrect[1];
    }
}
