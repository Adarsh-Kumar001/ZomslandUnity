using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

  void Start(){
    
        Cursor.lockState = CursorLockMode.None;

  }

  public GameObject MyMainMenu;
  public GameObject Mycontrols;

  public GameObject areuSure;

    public void IntroStart(){
       SceneManager.LoadScene(1);
    }

    public void MainMenu(){
      SceneManager.LoadScene(0);
    }

    public void GameStart(){
        SceneManager.LoadScene(2);
    }

    public void BackToMainMenu(){
       MyMainMenu.SetActive(true);
       Mycontrols.SetActive(false);
       areuSure.SetActive(false);
    }
    public void GoToControls(){
      MyMainMenu.SetActive(false);
      Mycontrols.SetActive(true);
      areuSure.SetActive(false);
    }

    public void AreUsure(){
       MyMainMenu.SetActive(false);
      Mycontrols.SetActive(false);
      areuSure.SetActive(true);
    }

    public void Quit(){
      Application.Quit();
    }
}

