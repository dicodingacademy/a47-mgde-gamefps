using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
[RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))] 

public class AIEnemyControl : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent agent { get; private set; }   
	public float speed;
	GameObject target; 

	// Use this for initialization
	void Start () {
		agent = GetComponentInChildren<NavMeshAgent>();
		target = GameObject.FindGameObjectWithTag("Player");
		agent.updateRotation = true;
		agent.speed = speed;
		agent.updatePosition = true; 
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null)
			agent.SetDestination(target.transform.position); 
	}
}
