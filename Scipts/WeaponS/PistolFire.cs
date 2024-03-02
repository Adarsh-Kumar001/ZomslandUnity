using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    

     public GameObject gun;

     public GameObject castobject;

     public float damage = 20f;
     public float range = 100f;

     public AudioSource pistolfireFX;

     public GameObject muzzleflash;
     public bool isFiring = false;
     public float toTarget;
     public GameObject crosshair;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(isFiring==false && PistolAmmo.ammocount>0){
                StartCoroutine(FirePistol());
                
            }
        }
    }

    IEnumerator FirePistol(){
        isFiring = true;
        toTarget = PlayerCasting.distFromTarget;
        gun.GetComponent<Animator>().Play("recoil 0");
        crosshair.GetComponent<Animator>().Play("fireCrossHair 0");
        pistolfireFX.Play();
        muzzleflash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleflash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        isFiring = false;
        PistolAmmo.ammocount--;
        gun.GetComponent<Animator>().Play("recoil");
        crosshair.GetComponent<Animator>().Play("null");

        
        RaycastHit hit;
       if(Physics.Raycast(castobject.transform.position, castobject.transform.forward, out hit, range));
       {
        
        Debug.Log(hit.transform.name);

        EnemyDamage target = hit.transform.GetComponent<EnemyDamage>();
        if(target != null){
            target.TakeDamage(damage);
        }
        
       } 
       

    }

    
}
