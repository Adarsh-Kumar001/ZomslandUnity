using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    public float intensity;
    public float smooth;
    private Quaternion target_rotate;
    private Quaternion origin_rotate;
   
     void Start(){
        origin_rotate = transform.localRotation;
     }
    // Update is called once per frame
    void Update()
    {
        Sway();
    }

    void Sway(){
      float xmouse = Input.GetAxis("Mouse X");
      float ymouse = Input.GetAxis("Mouse Y");
      Quaternion xadj = Quaternion.AngleAxis(-intensity*xmouse,Vector3.up);
      Quaternion yadj = Quaternion.AngleAxis(intensity*ymouse,Vector3.up);
      Quaternion target_rotate = origin_rotate * xadj *yadj;

      transform.localRotation = Quaternion.Lerp(transform.localRotation, target_rotate, Time.deltaTime*smooth);
      
    }

    
}
