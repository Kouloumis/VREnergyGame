using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : StateMachineBehaviour{

	protected bool SeeEnemy( Animator animator)
	{
		bool result = false;

		RaycastHit hit;
		float maxViewDistance = 12;

		if (Physics.Raycast(animator.transform.position, animator.transform.forward, out hit, maxViewDistance))
		{
			if (hit.collider.name == "Player" || hit.collider.name == "Gun")
			{
				result = true;
			}
            
		}

		return result;
	}

}