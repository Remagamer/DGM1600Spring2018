using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListsAndLoops : MonoBehaviour
{
	public TheInreadibles TheInreadibles;
	public Text AddMember;
	
	private void OnMouseDown()
	{
		TheInreadibles.FamilyList.Add(AddMember.text);
	}
}