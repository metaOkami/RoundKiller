using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerInput playerInput;
    public Animator playerAnimator;
    private void OnAndar(InputValue value){
        playerAnimator.SetTrigger("isWalking");
    }
}
