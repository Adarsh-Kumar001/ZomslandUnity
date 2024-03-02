using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
   
    public string hitTag;
    public Transform player;

    public GameObject enemy;

    public GameObject zombie;

    public GameObject guns;
    public float dist;
    
    public static float playerhealth = 100f;

    public AudioSource zombieattackfx;

    

    
  void Start(){
    playerhealth = 100f;
  }
    

    // Update is called once per frame
    void Update()
    {
       enemy.GetComponent<NavMeshAgent>().SetDestination(player.position);

       dist = Vector3.Distance(player.transform.position, this.gameObject.transform.position);
       if(dist <= 3){
        playerhealth -=20*Time.deltaTime;
       
       zombieattackfx.Play();
       
            zombie.GetComponent<Animator>().SetBool("Walk",false);
            zombie.GetComponent<Animator>().SetBool("Idle",false);
            zombie.GetComponent<Animator>().SetBool("Gethit",false);
            zombie.GetComponent<Animator>().SetBool("Attack",true);
       }
       else{
        zombie.GetComponent<Animator>().SetBool("Attack",false);
       }

        RaycastHit Hit;
        if(Physics.Raycast(transform.position, transform.forward, out Hit)){
            hitTag = Hit.transform.tag;
            
        }
        
        if(hitTag == "Player" && EnemyDamage.isdead == false){
           if(dist>3){
            zombie.GetComponent<Animator>().SetBool("Walk",true);
            zombie.GetComponent<Animator>().SetBool("Idle",false);
            zombie.GetComponent<Animator>().SetBool("Gethit",false);
            zombie.GetComponent<Animator>().SetBool("Death",false);
           
            enemy.GetComponent<NavMeshAgent>().speed = 7;
           }
        }
        else{
           if(EnemyDamage.isdead == false && dist>3){
            zombie.GetComponent<Animator>().SetBool("Idle",true);
            zombie.GetComponent<Animator>().SetBool("Walk",false);
            zombie.GetComponent<Animator>().SetBool("Gethit",false);
            zombie.GetComponent<Animator>().SetBool("Death",false);
            
            enemy.GetComponent<NavMeshAgent>().speed = 2;
        }
        }
       if(playerhealth <= 0){
        zombie.GetComponent<EnemyLook>().enabled = false;
         zombie.GetComponent<Animator>().SetBool("Idle",true);
         zombie.GetComponent<Animator>().SetBool("Walk",false);
        this.gameObject.SetActive(false);
        guns.SetActive(false);
        Debug.Log("PLayer Dead");
       }
    }
}

