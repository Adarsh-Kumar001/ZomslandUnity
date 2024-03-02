using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m4Fire : MonoBehaviour
{
    

     public GameObject gun;

     public GameObject castobject;

     public float damage = 25f;

     public float range = 200f;
     public GameObject muzzleflash;

     public AudioSource m4fireFX;
     public bool isFiring = false;

     public float toTarget;

     public GameObject crosshair;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            if(isFiring==false && M4ammo.m4ammocount>0){
                StartCoroutine(FireM4());
                
            }
        }
    }

    IEnumerator FireM4(){
        isFiring = true;
        toTarget = PlayerCasting.distFromTarget;
        gun.GetComponent<Animator>().Play("recoil 0");
        crosshair.GetComponent<Animator>().Play("fireCrossHair 0");
        m4fireFX.Play();
        muzzleflash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleflash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        isFiring = false;
        M4ammo.m4ammocount--;
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
