using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{
    private Animator playerAnim;
    [SerializeField]private float playerSpeed = 2.0f;
    private CharacterController controller;
    private void Start()
    {
        playerAnim = GetComponent<Animator>();
        controller = gameObject.GetComponent<CharacterController>();
        
    }

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);
        
        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.SetBool("IsWalking",true);
        }
        else
        {
            playerAnim.SetBool("IsWalking",false);
            
        }

    }
}
