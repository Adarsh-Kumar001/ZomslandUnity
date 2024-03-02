using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    
    

    public GameObject player;

    public static bool isPlayerdead = false;

    void Update(){

        if(EnemyAI.playerhealth<=0){
            
            
           player.GetComponent<MovePlayer>().enabled = false;
           player.GetComponent<Animator>().enabled = true;
           player.GetComponent<Animator>().Play("playerdeath");

           isPlayerdead = true;
           
           
        }
        else{
            
        }
    }
    
}

