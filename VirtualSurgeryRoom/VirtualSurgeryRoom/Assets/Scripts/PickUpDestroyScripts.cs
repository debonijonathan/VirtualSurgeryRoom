using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDestroyScripts : MonoBehaviour
{
    public Transform theDest;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown(){

        Destroy(this.gameObject);
    }

    void OnMouseUp(){


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
