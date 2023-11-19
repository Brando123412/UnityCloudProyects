using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == this.gameObject.tag){
            if(other.CompareTag("Player1")){
                //suscribirse a ....
                //Hacer el punto ...
                //Desuscribirse ...
                Destroy(this.gameObject);
            }else if(other.CompareTag("Player2")){
                //suscribirse a ....
                //Hacer el punto ...
                //Desuscribirse ...
                Destroy(this.gameObject);
            }
        }
    }
}

