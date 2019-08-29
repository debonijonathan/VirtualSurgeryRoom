using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsScripts : MonoBehaviour
{
    public GameObject light;
    public GameObject textOpen;

	private AudioSource audioData;

    private bool trigger = false;
    private bool flag = true;
    void Start () { //what happens in the beginning of the game.
	    light.SetActive (true);
		textOpen.SetActive (false);
        audioData = GetComponent<AudioSource>();

	}

    // Update is called once per frame
    void Update()
    {
        if(trigger && Input.GetKeyUp (KeyCode.E)){
            flag = !flag;
            light.SetActive (flag);
            audioData.Play(0);
        }

    }

    public void Enter(){
            trigger = true;

            flag = !flag;
            light.SetActive (flag);
            audioData.Play(0);

            textOpen.SetActive (true);
    }

    public void Exit(){
            trigger = false;
            textOpen.SetActive (false);
    }

    void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
            Enter();

		}
		
	}


	void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
            Exit();

		}

	}
}
