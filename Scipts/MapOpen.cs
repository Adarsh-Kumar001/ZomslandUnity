using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpen : MonoBehaviour
{
      public GameObject openMap;

      public GameObject dispText;

      public GameObject player;

      public float toDist;
    

        void Update()
    {
        toDist = Vector3.Distance(this.gameObject.transform.position, player.transform.position);
         
         if(toDist<3 ){
            if (Input.GetKey(KeyCode.F)){
                
                openMap.SetActive(true);
                
            }
        }
        else{
            openMap.SetActive(false);
        }

    }

    void OnMouseEnter(){
       if(toDist<3){
        dispText.SetActive(true);
       }
    }

        void OnMouseExit(){
        dispText.SetActive(false);
    }
}

