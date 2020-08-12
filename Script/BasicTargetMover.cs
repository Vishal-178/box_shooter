using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public bool DoSpin = true;
    public float SpinSpeed = 180f;
    public bool DoMotion = false;
    public float MotionMagnitude = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (DoSpin)
            gameObject.transform.Rotate(Vector3.up * SpinSpeed * Time.deltaTime);
        if(DoMotion)
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * MotionMagnitude);
    }
}
