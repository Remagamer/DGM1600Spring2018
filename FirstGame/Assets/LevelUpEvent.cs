using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelUpEvent : GameEvents {
	
	public override void EventListener()
	{
		Debug.Log("Level Up");
	}
}
