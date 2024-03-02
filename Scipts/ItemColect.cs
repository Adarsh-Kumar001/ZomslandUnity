using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColect : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource collectfx;

    public GameObject item;
    void OnTriggerEnter(Collider other){
       collectfx.Play();
       ItemManager.itemCount += 1;
        this.gameObject.SetActive(false);
        item.SetActive(false);

    }
}
