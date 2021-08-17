using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    // This script file uses for single object with single animation. 
    // The name of the animation should be the same as the object name.


    private Animator anim;
    private string animName;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        animName = gameObject.name;
        Debug.Log(anim);

        Debug.Log(animName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayInteraction()
    {
        anim.Play(animName);
    }
}
