using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myMove : MonoBehaviour
{
    public Transform theDest;

    private float x;

    void Start()
    {
        x = transform.eulerAngles.x;
    }
    void OnMouseDown(){
        //GetComponent<BoxCollider>().enabled = false;
 
        GetComponent<Rigidbody>().useGravity = true;
        Vector3 v = new Vector3();


        transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);


        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp(){
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;

        transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
