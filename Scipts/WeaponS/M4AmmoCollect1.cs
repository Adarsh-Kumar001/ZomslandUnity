using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4AmmoCollect1 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource ammoPickfx;

    public GameObject plustenammo;
    void OnTriggerEnter(Collider other){
        ammoPickfx.Play();
        M4ammo.m4ammocount += 20;
        this.gameObject.SetActive(false);
        plustenammo.SetActive(true);
      
    }

}
