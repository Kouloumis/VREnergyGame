using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour {
    
    [SerializeField]
    Material MaterialChange;

    [SerializeField]
    Material Normal;


    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Player") {

            GetComponent<Renderer>().material = MaterialChange;

        }
    }

    void OnCollisionExit(Collision collision)
    {
       GetComponent<Renderer>().material = Normal;

    }
}
