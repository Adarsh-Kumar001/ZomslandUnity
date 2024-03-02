using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
     public float movespeed = 6f;
     public CharacterController controller;

     Vector3 velocity;
     public float gravity = -19.62f;

     //public float jumpHeight = 3f;

     public Transform groundCheck;
     public float groundDist = 0.4f;
     public LayerMask groundmask;

     bool isGrounded;

     
      //FOR ANDROID
     public FixedJoystick joystick;
      // FOR ANDROID END

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDist,groundmask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //FOR ANDROID
         float x = joystick.Horizontal;

         float z = joystick.Vertical;
        //FOR ANDROID END

        Vector3 move = (transform.right*x)/2 + transform.forward*z;

        if(Input.GetKey(KeyCode.LeftShift)){
            movespeed = 12f;
        }
        else{
            movespeed = 6f;
        }

        controller.Move(move * movespeed * Time.deltaTime);

        //if(Input.GetButtonDown("Jump") && isGrounded){
            //velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        


    }
}
