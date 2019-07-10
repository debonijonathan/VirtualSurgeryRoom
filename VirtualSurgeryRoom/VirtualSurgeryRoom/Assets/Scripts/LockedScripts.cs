using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedScripts : MonoBehaviour
{

    public bool trigger = false;


    public GameObject LockedSound;

    public GameObject textOpen;
	public GameObject textLocked;

    // Start is called before the first frame update
    void Start()
    {
        	textLocked.SetActive (false);
            LockedSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger && Input.GetKeyDown (KeyCode.E)){
            textOpen.SetActive (false);
			textLocked.SetActive (true);
            LockedSound.SetActive(true);
            trigger = false;
        }
    }

    void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
			textOpen.SetActive (true);
            trigger = true;
		}
	}

    void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
            textOpen.SetActive (false);
			textLocked.SetActive (false);
            LockedSound.SetActive(false);
            trigger = false;

		}

	}
}
