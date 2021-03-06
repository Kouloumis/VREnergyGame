﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	float throwForce = 1000;
	Vector3 objectPos;
	float distance;

	public bool canHold = true;
	public GameObject item;
	public GameObject tempParent;
	public bool isHolding = false;

    private bool trigger = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
		if (distance >= 1f)
		{
			isHolding = false;
		}
		//check if isHolding
		if (isHolding == true)
		{
			item.GetComponent<Rigidbody>().velocity = Vector3.zero;
			item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			item.transform.SetParent(tempParent.transform);

			if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Joystick1Button8))
			{
				item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
				isHolding = false;
			}
            
		}
		else
		{
			objectPos = item.transform.position;
			item.transform.SetParent(null);
			item.GetComponent<Rigidbody>().useGravity = true;
			item.transform.position = objectPos;
		}

        //Holding the item

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Joystick1Button4)) {
            if (distance <= 1f)
            {
                isHolding = true;
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().detectCollisions = true;
            }
        }

        //Releasing the item
        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Joystick1Button4))
        {
            {
                isHolding = false;
            }
        }
    }

}
