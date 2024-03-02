using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEquipt : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;

    public GameObject PistolAmmoPanel;

    public GameObject M4AmmoPanel;

    public GameObject crosshairDefault;

    public GameObject crosshairGun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1")){
            Weapon1();
            
        }
        if(Input.GetKeyDown("2")){
            Weapon2();
        }
    }

    void Weapon1(){
        if (Slot1.activeSelf){
            Slot1.SetActive(false);
            Slot2.SetActive(false);
            PistolAmmoPanel.SetActive(false);
            M4AmmoPanel.SetActive(false);
            
            crosshairDefault.SetActive(true);
            crosshairGun.SetActive(false);
        }
        else{
            Slot1.SetActive(true);
            Slot2.SetActive(false);
            PistolAmmoPanel.SetActive(true);
            M4AmmoPanel.SetActive(false);

            crosshairDefault.SetActive(false);
            crosshairGun.SetActive(true);
        }

    }
    void Weapon2(){
        if (Slot2.activeSelf){
            Slot2.SetActive(false);
            Slot1.SetActive(false);
            PistolAmmoPanel.SetActive(false);
            M4AmmoPanel.SetActive(false);

            crosshairDefault.SetActive(true);
            crosshairGun.SetActive(false);
        }
        else{
            Slot2.SetActive(true);
            Slot1.SetActive(false);
            PistolAmmoPanel.SetActive(false);
            M4AmmoPanel.SetActive(true);

            crosshairDefault.SetActive(false);
            crosshairGun.SetActive(true);
            
        }

    }
}
