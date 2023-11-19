using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject objeto;
    [SerializeField] Vector2 posicion;

    void Start()
    {
        SpawnEnemies();
    }
    public void SpawnEnemies()
    {
        int xpos = Random.Range(-4,4);
        int ypos = Random.Range(-4, 4);
        posicion=new Vector2(xpos,ypos);
        Instantiate(objeto, posicion, Quaternion.identity);
    }
    public void SpawnEnemiesReact(){
        
    }
}
