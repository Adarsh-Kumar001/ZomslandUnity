using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float toDist;
    public GameObject dispText;

     public GameObject OpenText;

    public GameObject Door;

    public GameObject player;

    public GameObject button;

    public bool isItemsCollected = false;


    // Update is called once per frame
    void Update()
    {
        toDist = PlayerCasting.distFromTarget;

        if(button.activeSelf){
           isItemsCollected = true;
        }
        if(toDist<3 && isItemsCollected == true){
            if (Input.GetKey(KeyCode.F)){
                Door.GetComponent<Animator>().Play("gateopen");
                button.SetActive(false);
            }
        }


    }

    void OnMouseEnter(){
        if(toDist<3 && isItemsCollected == false){
            dispText.SetActive(true);
        }

        if(toDist<3 && isItemsCollected == true){
            OpenText.SetActive(true);
            //if (Input.GetKey(KeyCode.F)){
                //Door.GetComponent<Animator>().Play("gateopen");
            //}
        }

    }
    void OnMouseExit(){
            dispText.SetActive(false);
            OpenText.SetActive(false);
    }
}
