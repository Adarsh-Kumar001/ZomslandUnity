using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    public GameObject youDeadText;
    

    // Update is called once per frame
    void Update()
    {
        if(EnemyAI.playerhealth <= 0){
            StartCoroutine(DeadPlayer());
        }
    }

    IEnumerator DeadPlayer(){
        yield return new WaitForSeconds(1f);
        youDeadText.SetActive(true);
         yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(2);

    }
}
