using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{

    private Camera refCamera;

    void Start()
    {
        if(refCamera == null)
        {
            refCamera = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.forward = refCamera.transform.forward;
        //transform.rotation = refCamera.transform.rotation;

        Vector3 targetPos = transform.position + refCamera.transform.rotation * Vector3.forward;
        Vector3 targetOrientation = refCamera.transform.rotation * Vector3.up;
        transform.LookAt(targetPos, targetOrientation);
    }
}
