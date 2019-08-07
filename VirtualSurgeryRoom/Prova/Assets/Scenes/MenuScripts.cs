using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;
public class MenuScripts : MonoBehaviour
{
    public EventSystem eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quit(){
        Debug.Log("quit");
                Application.Quit();

    }
}
