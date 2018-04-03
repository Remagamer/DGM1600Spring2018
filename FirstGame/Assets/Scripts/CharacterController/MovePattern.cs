using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovePattern")]
public class MovePattern : MovePatternBase {

		
	public override void Move(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			rotateDirection.x = InputRotateX.SetFloat();
			rotateDirection.y = InputRotateY.SetFloat();
			rotateDirection.z = InputRotateZ.SetFloat();
			transform.Rotate(rotateDirection);
			
			moveDirection.x = InputX.SetFloat();
			moveDirection.z = InputZ.SetFloat();
			
			moveDirection = transform.TransformDirection(moveDirection);
			
			moveDirection *= speed;	
			moveDirection.y = JumpInput.SetFloat();
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}	
}