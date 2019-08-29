using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class AnimationInteractableScripts : MonoBehaviour
{
//Text variables
	public bool T_ActivatedOpen = true;
	public bool T_ActivatedClose = false;
	public bool activateTrigger = false;

	public GameObject textOpen;

	//Animator variables
	Animator animator;
	bool doorOpen;
	//Sound variables
	public GameObject doorOpenSound;
	public GameObject doorCloseSound;

	public SteamVR_ActionSet m_action;


	void Start () { //what happens in the beginning of the game.
		textOpen.SetActive (false);
		T_ActivatedOpen = true;
		T_ActivatedClose = false;

		animator = GetComponent<Animator> ();
		doorOpen = false;


		doorCloseSound.SetActive (false);
		doorOpenSound.SetActive (false);
	
	}
	

	void Update () { //The main function wich controlls how the system will work.

	}

	public void Enter(){
		if(SteamVR_Actions.default_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any)){
			Debug.Log("Grab Pinch");
		}
		Debug.Log("QUAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
			Debug.Log(SteamVR_Actions.default_GrabGrip.GetStateUp(SteamVR_Input_Sources.Any));
			Debug.Log(SteamVR_Actions.default_GrabGrip.GetStateDown(SteamVR_Input_Sources.Any));

		doorOpen = !doorOpen;
		if(doorOpen){
			doorController ("Open");
			doorCloseSound.SetActive (false);
			doorOpenSound.SetActive (true);
		}else{
			doorController ("Close");
			doorCloseSound.SetActive (true);
			doorOpenSound.SetActive (false);
		}
	}

	public void Exit(){

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

	void doorController(string direction) //Animator function.
	{
		animator.SetTrigger(direction);
	}
}
