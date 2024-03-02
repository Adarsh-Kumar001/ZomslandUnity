using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class M4ammo : MonoBehaviour
{
    public TMP_Text AmmoText;
    public static int m4ammocount = 20;

   void Start(){
    m4ammocount = 20;
   }

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = "AMMO: "+m4ammocount;
    }
}
