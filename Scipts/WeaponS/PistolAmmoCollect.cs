using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoCollect : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource ammoPickfx;

    public GameObject plusten;
    void OnTriggerEnter(Collider other){
        ammoPickfx.Play();
       PistolAmmo.ammocount += 10;
        this.gameObject.SetActive(false);
        plusten.SetActive(true);

    }
}
