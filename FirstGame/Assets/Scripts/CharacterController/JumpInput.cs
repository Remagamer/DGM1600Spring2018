using UnityEngine;

[CreateAssetMenu(fileName = "JumpInput")]
public class JumpInput : InputBase
{
	public float FloatValue = 1;
	
	public override float SetFloat()
	{
		return Input.GetButton("Jump") ? FloatValue : 0;
	}
}
