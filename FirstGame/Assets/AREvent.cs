using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AREvent : MonoBehaviour
{
	public UnityEvent Response;
	
	void OnMouseDown () {
		Response.Invoke();
	}
}
