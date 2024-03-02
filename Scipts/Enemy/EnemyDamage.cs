using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDamage : MonoBehaviour
{
    
    public float health = 100f;

    public GameObject Enemy;

    public GameObject zombie;

    public static bool isdead = false;

    public AudioSource zombieHitfx;

    public AudioSource zombieDeathfx;

    public void TakeDamage(float amount){
       
        health -= amount;

        if(health<=0){
            
            zombie.GetComponent<Animator>().SetBool("Idle",false);
            zombie.GetComponent<Animator>().SetBool("Walk",false);
            zombie.GetComponent<Animator>().SetBool("Gethit",false);
            zombie.GetComponent<Animator>().SetBool("Death",true);
            zombie.GetComponent<Animator>().SetBool("Attack",false);
           this.gameObject.GetComponent<EnemyLook>().enabled = false;
           Enemy.GetComponent<NavMeshAgent>().enabled = false;
           isdead = true;
           StartCoroutine(DestroyEnemy());
           
           
        }
        else{
            zombie.GetComponent<Animator>().SetBool("Idle",false);
            zombie.GetComponent<Animator>().SetBool("Walk",false);
            zombie.GetComponent<Animator>().SetBool("Gethit",true);
            zombie.GetComponent<Animator>().SetBool("Death",false);
            zombie.GetComponent<Animator>().SetBool("Attack",false);

            zombieHitfx.Play();
        }
    }
    void Update(){
        if(isdead == true)
        {
            zombie.GetComponent<Animator>().SetBool("Idle",false);
            zombie.GetComponent<Animator>().SetBool("Walk",false);
            zombie.GetComponent<Animator>().SetBool("Gethit",false);
            zombie.GetComponent<Animator>().SetBool("Attack",false);
            
        }
    }
    
    IEnumerator DestroyEnemy(){
        zombieDeathfx.Play();
        yield return new WaitForSeconds(1.2f);
        Destroy(Enemy);
        isdead = false;
        
    }
}
