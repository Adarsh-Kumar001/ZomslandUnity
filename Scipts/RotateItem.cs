using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{
    public float rotateSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0,rotateSpeed*Time.deltaTime,0,Space.World);
    }
}
