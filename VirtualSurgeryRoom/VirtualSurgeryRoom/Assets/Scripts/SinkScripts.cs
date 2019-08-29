using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkScripts : MonoBehaviour
{
    public ParticleSystem water;
    public GameObject waterSound;

    // Start is called before the first frame update
    void Start()
    {
        //rend = GetComponenent<ParticleSystem>();
        water.Stop();
        waterSound.SetActive (false);

    }
    
	public void Enter(){
			water.Play(); 
			waterSound.SetActive (true);
	}

	public void Exit(){
			water.Stop();
            waterSound.SetActive (false);
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
