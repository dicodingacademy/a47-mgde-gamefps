using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


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
		transform.Translate (0,0,CrossPlatformInputManager.GetAxis("Vertical")*speed*Time.deltaTime);
		transform.Rotate (0, CrossPlatformInputManager.GetAxis("Horizontal")*60*Time.deltaTime, 0);

		//Tekan Space untuk melontarkan Ball
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
			GameObject _ball = GameObject.Instantiate (ball, 
				titikLontar.transform.position, titikLontar.transform.rotation);
			_ball.GetComponent<Rigidbody> ().AddForce (_ball.transform.forward 
				* powerLontar);
			GameObject.Destroy (_ball, 5);
		}
	}
}