using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
     public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.activeSelf){
          if(Input.GetKeyDown(KeyCode.Escape)){
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
             //Cursor.lockState = CursorLockMode.Locked;
        }
        }
        else{
            if(Input.GetKeyDown(KeyCode.Escape)){
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }

    public void pausetheGame(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
         Cursor.lockState = CursorLockMode.None;
    }

    public void resumetheGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
         //Cursor.lockState = CursorLockMode.Locked;
    }

    public void exitToMainMenu(){
        SceneManager.LoadScene(0);
         Time.timeScale = 1f;
    }
}
