using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {
    
    public GameObject Particlez;
    public GameObject HappyCube;

    public GameObject Troll;

	// Use this for initialization
	void Start () {

        Troll.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

      //  float moveHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.JoystickButton2) || Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(Particlez, HappyCube.transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            Troll.SetActive(true);
        }

    }

}
