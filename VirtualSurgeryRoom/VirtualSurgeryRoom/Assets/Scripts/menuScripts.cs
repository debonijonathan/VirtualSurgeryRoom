using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class menuScripts : MonoBehaviour
{
    int index = 0;

    public EventSystem eventSystem;

    public GameObject play;
    public GameObject quit;
    public void Update(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            index = 0;
            eventSystem.SetSelectedGameObject(play);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            index = 1;
            eventSystem.SetSelectedGameObject(quit);

        }
        
        if(Input.GetKeyDown(KeyCode.Return)){
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
