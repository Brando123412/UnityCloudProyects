using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControllerGame2 : MonoBehaviour
{
    Rigidbody2D rb2d;
    float horizontal;
    CapsuleCollider2D myBoxCollider;
    SpriteRenderer spr;
    [SerializeField] float forceSpeed;
    [SerializeField] float forceJump;
    [SerializeField] bool flip = false;

    
    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
        myBoxCollider=GetComponent<CapsuleCollider2D>();
        spr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
    }
    private void Update() {
        if(horizontal<0){
            flip = true;
        }else if(horizontal>0){
            flip = false;
        }
        spr.flipX=flip;
    }
    void FixedUpdate() {
        rb2d.velocity= new Vector2(horizontal,rb2d.velocity.y);
    }
    public void OnMovimiento(InputAction.CallbackContext value){
        horizontal= value.ReadValue<float>(); 
        
    }
    public void OnJump(InputAction.CallbackContext value){
        if(value.started){
            if(myBoxCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))){
                rb2d.velocity =  new Vector2(rb2d.velocity.x,forceJump );
            }
        }
    }
}
