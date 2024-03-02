using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distFromTarget;

    public float toTarget;


    // Update is called once per frame
    void Update()
    {
       RaycastHit Hit;
       if(Physics.Raycast(transform.position, transform.forward, out Hit));
       {
        toTarget = Hit.distance;
        distFromTarget = toTarget;

        
        
       } 
    }
}
