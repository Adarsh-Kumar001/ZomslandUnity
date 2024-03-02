using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOne : MonoBehaviour
{
    public GameObject OldObjective;
    public GameObject NewObjective;
    void OnTriggerEnter(Collider other){
       
       
        this.gameObject.SetActive(false);
        OldObjective.SetActive(false);
        NewObjective.SetActive(true);

    }
}
