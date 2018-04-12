using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowParticle : MonoBehaviour
{

	public GameObject particle;
	Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> (); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Destroy")) {
			Destroy (gameObject);
			GameObject p = GameObject.Instantiate (particle,transform.position,transform.rotation);
			Destroy (p,1);
		} 
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag.Equals ("Player") || collision.gameObject.tag.Equals ("Bullet")) {         
			anim.SetBool ("isDead", true);
		} 
	}
}
