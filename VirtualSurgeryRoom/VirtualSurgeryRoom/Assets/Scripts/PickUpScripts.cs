using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScripts : MonoBehaviour
{
    public Transform theDest;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown(){
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp(){
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
