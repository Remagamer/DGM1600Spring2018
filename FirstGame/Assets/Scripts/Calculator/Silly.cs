using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Silly : Calculation {
	
	public string[] SillyStuff;
	public int i = 0;
	
	public override string FinishCalculation()
	{
		i = UnityEngine.Random.Range(0, SillyStuff.Length - 1);
		return SillyStuff[i];
	}
	
}