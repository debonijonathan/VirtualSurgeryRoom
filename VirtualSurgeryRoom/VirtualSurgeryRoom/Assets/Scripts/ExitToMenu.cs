using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class ExitToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Enter(){
        Debug.Log("ESCI");
        SceneManager.LoadScene("Menu");
    }

    public void Exit(){

    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp (KeyCode.Q)){
            Enter();
        }

            if(SteamVR_Actions.default_GrabGrip.GetStateDown(SteamVR_Input_Sources.Any) && 
            SteamVR_Actions.default_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any)){
                Enter();

            }

    }
}
