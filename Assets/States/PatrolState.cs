﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State {

	[SerializeField]

	float rotationSpeed;

	//  OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		animator.GetComponent<Renderer>().material.color = Color.green;
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		animator.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

		if (SeeEnemy(animator))
		{
			animator.SetInteger("CameraState", 1);
		}
	}

}
