using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class AIAgent : MonoBehaviour
{

	private NavMeshAgent Agent;
	private Animator Anims;

	void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Anims = GetComponent<Animator>();
	}

	private void OnTriggerEnter(Collider other)
	{
		Anims.SetTrigger("ChangeState");
	}
}