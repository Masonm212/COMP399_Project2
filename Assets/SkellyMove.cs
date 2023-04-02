using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyMove : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            anim.SetTrigger("Walk");
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Dead");
        }
    }
}
