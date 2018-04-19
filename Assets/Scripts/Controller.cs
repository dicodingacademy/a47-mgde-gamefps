using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Camera.main.transform.forward*getAnalog().y*speed*Time.deltaTime);
        //transform.Rotate (0,getAnalog().x*60*Time.deltaTime, 0);
	}

    Vector2 getKeyboard() {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    Vector2 getAnalog() {
        
        return OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
    }
}
