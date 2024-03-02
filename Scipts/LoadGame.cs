using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public float waitTime = 28f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        StartCoroutine(GameLoad());
    }

    IEnumerator GameLoad(){
      yield return new WaitForSeconds(waitTime);
      SceneManager.LoadScene(2);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(2);
        }
    }

    public void SkipToGame(){
         SceneManager.LoadScene(2);
    }

    
}
