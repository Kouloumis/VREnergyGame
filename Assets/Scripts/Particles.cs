using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {
    
    public GameObject Particlez;
    public GameObject HappyCube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

      //  float moveHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            Instantiate(Particlez, HappyCube.transform.position, Quaternion.identity);
        }


    }

}
