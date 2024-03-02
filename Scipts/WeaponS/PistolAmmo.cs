using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PistolAmmo : MonoBehaviour
{
    public TMP_Text AmmoText;
    public static int ammocount = 20;

    
    void Start(){
    ammocount = 20;
   }
   

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = "AMMO: "+ammocount;


    }


}
