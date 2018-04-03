using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Hey there!
	// Use this for initialization
	void Start () {
		print("I love my cat.");
		print("No, I really don't.");
	}
	
	void OnMouseDown()
	{
		Start();
		print("Meow.");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
