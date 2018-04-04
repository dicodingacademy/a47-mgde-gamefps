using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	public GameObject ball;
	public GameObject titikLontar;
	public float powerLontar; 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,0,Input.GetAxis("Vertical")*speed*Time.deltaTime);
		transform.Rotate (0, Input.GetAxis ("Horizontal")*60*Time.deltaTime, 0);

		//Tekan Space untuk melontarkan Ball
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			GameObject _ball = GameObject.Instantiate (ball, 
				titikLontar.transform.position, titikLontar.transform.rotation);
			_ball.GetComponent<Rigidbody> ().AddForce (_ball.transform.forward 
				* powerLontar);
			GameObject.Destroy (_ball, 5);
		}
	}
}
