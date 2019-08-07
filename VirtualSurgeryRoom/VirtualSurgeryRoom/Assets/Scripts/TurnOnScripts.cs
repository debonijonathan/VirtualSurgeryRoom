using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnScripts : MonoBehaviour
{
    public Material[] material;
    public GameObject textOpen;

    public int nr_mat;
    Renderer rend;

    private Material[] oldMaterials;
    private AudioSource audioData;

    private bool triggered = false;
    private bool status = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        textOpen.SetActive (false);
        audioData = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if(triggered && Input.GetKeyUp (KeyCode.E)){
            status = !status;
            oldMaterials = rend.materials;
            if(status){
                oldMaterials[nr_mat] = material[1];
            }else{
                oldMaterials[nr_mat] = material[0];
            }
            rend.materials = oldMaterials;
            audioData.Play(0);

        }

    }

    void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
		    textOpen.SetActive (true);

            triggered = true;
		}
	}

    void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
            textOpen.SetActive (false);
            triggered = false;

		}

	}
}
