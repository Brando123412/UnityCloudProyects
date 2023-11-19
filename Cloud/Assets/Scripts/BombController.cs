using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public float explosionDelay = 2.0f; // Tiempo antes de que explote la bomba
    public GameObject explosionPrefab; // Prefab de la explosión
    

    private void Start()
    {
        // Inicia una cuenta regresiva para la explosión
        Invoke("Explode", explosionDelay);
    }

    private void Explode()
    {
        // Crea una explosión en la posición de la bomba
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        // Destruye la bomba
        Destroy(gameObject);
        print("gaa");
    }
}
