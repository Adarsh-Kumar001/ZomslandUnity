using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MouseSensitivity = 100f;

    public Transform character;
    float xRotate = 0f;

    private float xMove;

    private float yMove;

    //FOR ANDROID
    public FixedJoystick joystick;
    //FOR ANDROID END

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        //float xMove = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        //float yMove = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;


        // FOR ANDROID
         xMove = joystick.Horizontal;

         yMove = joystick.Vertical;

          xMove *= MouseSensitivity;
          yMove *= MouseSensitivity;

        // FOR ANDROID END


        xRotate -= yMove * Time.deltaTime;
        xRotate = Mathf.Clamp(xRotate,-90f,90f);

        transform.localRotation = Quaternion.Euler(xRotate,0f,0f);
        character.Rotate(Vector3.up * xMove * Time.deltaTime);

        
       

        

        
        
    }
}
