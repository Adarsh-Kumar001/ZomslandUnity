using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int itemCount = 0;

    public GameObject oldObjective;

    public GameObject newObjective;

    public GameObject button;

    public GameObject enemyWave2;

    // Update is called once per frame
    void Update()
    {
        if(itemCount == 3){
           oldObjective.SetActive(false);
           newObjective.SetActive(true);
           button.SetActive(true);
        }
        if(itemCount == 2){
            enemyWave2.SetActive(true);
        }
    }
}
