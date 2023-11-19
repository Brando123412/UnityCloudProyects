using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento del jugador
    public GameObject bombPrefab;
    float horizontalInput = 0;
    float verticalInput = 0;
    
    Rigidbody2D rb2d;
    private void Awake() {
        rb2d=GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Obtener la entrada del teclado
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Calcular la dirección de movimiento

        // Mover al jugador
        //transform.Translate(movement * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            DropBomb();
        }
    }
    private void FixedUpdate() {
        rb2d.velocity= new Vector2(horizontalInput*speed, verticalInput*speed);
    }
    private void DropBomb()
    {
        // Crea una bomba en la posición del jugador
        Instantiate(bombPrefab, transform.position, Quaternion.identity);
    }
}
