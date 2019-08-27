using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;
using Valve.VR;

public class menuScripts : MonoBehaviour
{
    int index = 0;

    public EventSystem eventSystem;

    public GameObject play;
    public GameObject quit;
    public GameObject player;
    public void Update(){
        if(Input.GetKeyDown(KeyCode.UpArrow) || SteamVR_Actions.default_GrabGrip.GetStateDown(SteamVR_Input_Sources.Any)){
            index = 0;
            eventSystem.SetSelectedGameObject(play);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) || SteamVR_Actions.default_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any)){
            index = 1;
            eventSystem.SetSelectedGameObject(quit);

        }
        
        if(Input.GetKeyDown(KeyCode.Return) || SteamVR_Actions.default_Teleport.GetStateDown(SteamVR_Input_Sources.Any)){
             Destroy(player);
            if(index == 0){
                NewGameBtn("SampleScene");
            }else{
                ExitGameBtn();
            }
        }
    }
    public void NewGameBtn(string newGamelevel){
        SceneManager.LoadScene(newGamelevel);
    }

    public void ExitGameBtn(){
        Application.Quit();
    }

}
