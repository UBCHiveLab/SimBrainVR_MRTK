using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeDialogueBubble : MonoBehaviour
{
    public GameObject dialogueBubblePrefab;
    public Vector3 pos;


    void Start()
    {
        pos = transform.position;
        Debug.Log(pos);
        Instantiate(dialogueBubblePrefab, new Vector3(pos.x-0.25f, pos.y + 2f, pos.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
