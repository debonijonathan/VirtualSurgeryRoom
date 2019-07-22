using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myMove : MonoBehaviour
{
    public Transform theDest;

    void OnMouseDown(){
        //GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = true;
        Vector3 v = new Vector3();
        v.x = theDest.position.x;
        v.z = theDest.position.z;
        v.y = this.transform.position.y;
        this.transform.position = v;

        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp(){
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        //GetComponent<BoxCollider>().enabled = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
