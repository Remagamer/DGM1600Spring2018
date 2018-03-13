﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

[CreateAssetMenu]
public class Multiply : Calculation {
	public override float FinishCalculation()
	{
		return aNum * bNum;
	}
	
}