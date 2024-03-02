using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchControl : MonoBehaviour
{
    public GameObject torch;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            if(torch.activeSelf){
                torch.SetActive(false);
                Debug.Log("Off");
            }
            else{
                torch.SetActive(true);
                Debug.Log("On");
            }
        }
    }
}
