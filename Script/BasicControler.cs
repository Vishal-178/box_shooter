using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControler : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("horizontal Input = " +Input.GetAxis("Horizontal"));
    }
}
