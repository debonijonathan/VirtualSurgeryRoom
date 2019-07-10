using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScripts : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.enabled = false;
    }

    void OnTriggerEnter(Collider other){
        	
		if(other.gameObject.tag == "Player")
		{
            anim.enabled = true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player")
		{
            anim.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
