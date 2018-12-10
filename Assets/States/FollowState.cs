using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : State {

	GameObject player;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		animator.GetComponent<Renderer>().material.color = Color.red;

		player = GameObject.Find("Player");
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

		if(SeeEnemy(animator))
		{
			Vector3 targetDirection = player.transform.position - animator.transform.position;
			Vector3 newViewDirection = Vector3.RotateTowards(animator.transform.forward, targetDirection, 3f, 1f);
			animator.transform.rotation = Quaternion.LookRotation(newViewDirection);	
		}
		else
		{
			animator.SetInteger("CameraState", 2);
		}
		
	}

}
