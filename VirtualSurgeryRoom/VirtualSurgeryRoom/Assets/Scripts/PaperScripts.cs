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


    public void Enter(){
        anim.enabled = true;
    }

    public void Exit(){
        anim.enabled = false;
    }
    void OnTriggerEnter(Collider other){
        	
		if(other.gameObject.tag == "Player")
		{
            Enter();
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player")
		{
            Exit();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
