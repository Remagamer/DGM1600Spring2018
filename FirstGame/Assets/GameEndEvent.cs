using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEndEvent : GameEvents {
	
	public override void EventListener()
	{
		Debug.Log("EndGame");
	}
}
