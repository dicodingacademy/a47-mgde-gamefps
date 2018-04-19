using UnityEngine;
using UnityEngine.AI; 
[RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))] 

public class AIEnemyControl : MonoBehaviour {

	public NavMeshAgent agent { get; private set; }   
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
        if (target != null) {
            agent.SetDestination(target.transform.position);
        }
	}

    public void StopMove() {
        agent.updateRotation = false;
        agent.updatePosition = false;
    }
}
