using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Variable que contiene el asset de InputSystem que hemos creado posteriormente
    public PlayerActions playerInput;
    //Variable que contiene el animator del personaje
    public Animator playerAnimator;
    //Variable publica que contiene la velocidad a la que se mueve el jugador
    public float movementSpeed;
    //Variable que contiene el rigidbody del personaje principal
    Rigidbody rb;
    private Vector2 movement;

    private void Awake() {
        //Inicializamos la variable que contiene el asset creado del input system
        playerInput=new PlayerActions();
        //NOTYET
        playerInput.PlayerMovement.Andar.performed+=Movement_performed;
        //Obtenemos el rigidbody del personaje por codigo
        rb=this.GetComponent<Rigidbody>();

    }
    //Funcion que obtiene el valor vector2 que se emite al teclear uno de los controles bindeados 
    private void Movement_performed(InputAction.CallbackContext obj){
        
        Vector2 movement=obj.ReadValue<Vector2>();
        float speed=20f;
        rb.AddForce(new Vector3(movement.x,0,movement.y)*speed, ForceMode.Force);

    }

    
    private void FixedUpdate() {
        animationChecker();
        movement=playerInput.PlayerMovement.Andar.ReadValue<Vector2>();
        rb.AddForce(new Vector3(movement.x,0,movement.y)*movementSpeed, ForceMode.Force); 
    }
    //Funcion que habilita el mapa de PlayerMovement
    private void OnEnable() {

        playerInput.PlayerMovement.Enable(); 

    }
    //Funcion que deshabilita el mapa de PlayerMovement
    private void OnDisable() {

        playerInput.PlayerMovement.Disable();

    }

    private void animationChecker(){
        //Checkeamos si esta andando pero no animado o lo contrario
        if(movement.magnitude>0 || movement.magnitude<0 && !playerAnimator.GetBool("isWalking")){
            playerAnimator.SetBool("isWalking",true);
            Debug.Log("Esta andando");
        }
        else if(movement.magnitude==0){
            playerAnimator.SetBool("isWalking",false);
            Debug.Log("Esta quieto");
        }
        
    }
}
