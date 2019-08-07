using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{

    	//Animator variables
	Animator animator;
    // Start is called before the first frame update
    
	public GameObject doorOpenSound;
	public GameObject doorCloseSound;
    private bool trigger = false;

    void Start()
    {
        animator = GetComponent<Animator> ();
		doorCloseSound.SetActive (false);
		doorOpenSound.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
			doorController ("Open");
			doorCloseSound.SetActive (false);
			doorOpenSound.SetActive (true);
		}
		
	}


	void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
			doorController ("Close");
			doorCloseSound.SetActive (true);
			doorOpenSound.SetActive (false);
		}

	}

    void doorController(string direction) //Animator function.
	{
		animator.SetTrigger(direction);
	}
}
