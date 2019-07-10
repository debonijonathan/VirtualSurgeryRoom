using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScripts : MonoBehaviour
{
	//Text variables
	public bool T_ActivatedOpen = true;
	public bool T_ActivatedClose = false;
	public bool activateTrigger = false;

	public GameObject textOpen;
	public GameObject textClose;

	//Animator variables
	Animator animator;
	bool doorOpen;
	//Sound variables
	public GameObject doorOpenSound;
	public GameObject doorCloseSound;






	void Start () { //what happens in the beginning of the game.
		textClose.SetActive (false);
		textOpen.SetActive (false);
		T_ActivatedOpen = true;
		T_ActivatedClose = false;

		animator = GetComponent<Animator> ();
		doorOpen = false;


		doorCloseSound.SetActive (false);
		doorOpenSound.SetActive (false);



	
	}
	

	void Update () { //The main function wich controlls how the system will work.

		if (T_ActivatedOpen == true)
			T_ActivatedClose = false;

		else if (T_ActivatedClose == true)
			T_ActivatedOpen = false;

		if (T_ActivatedOpen && activateTrigger && Input.GetKeyDown (KeyCode.E)) //For some reaseon you can't have both E (open and close).
			{
				textOpen.SetActive (false);
				textClose.SetActive (false);
				T_ActivatedOpen = false;
				T_ActivatedClose = true;
				textOpen.SetActive (false);
				textClose.SetActive (true);
				doorOpen = true;

				doorOpenSound.SetActive (true);
				doorCloseSound.SetActive (false);

			if (doorOpen) 
			{
				doorOpen = true;
				doorController ("Open");
			}
				
			}
			else if(T_ActivatedClose && activateTrigger && Input.GetKey (KeyCode.F)) 
			{
				T_ActivatedOpen = true;
				T_ActivatedClose = false;
				textOpen.SetActive (true);
				textClose.SetActive (false);

				doorCloseSound.SetActive (true);
				doorOpenSound.SetActive (false);
	
			if (doorOpen) 
			{
				doorOpen = false;
				doorController ("Close");
			}
				
			} 
	}


														
	void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{

			activateTrigger = true;
			if((T_ActivatedOpen == true))
				textOpen.SetActive (true);

			if((T_ActivatedClose == true))
				textClose.SetActive (true);
		}
		
	}


	void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
			textOpen.SetActive (false);
			textClose.SetActive (false);
			activateTrigger = false;
		}

	}

	void doorController(string direction) //Animator function.
	{
		animator.SetTrigger(direction);
	}
		
}
