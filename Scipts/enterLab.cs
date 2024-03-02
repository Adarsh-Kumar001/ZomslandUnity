using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterLab : MonoBehaviour
{
    public GameObject fadeOut;
    void OnTriggerEnter(Collider other){
          fadeOut.SetActive(true);
          StartCoroutine(sceneChangetoLab());
    }

    IEnumerator sceneChangetoLab(){
        yield return new WaitForSeconds(1.7f);
        SceneManager.LoadScene(3);
    }
}
