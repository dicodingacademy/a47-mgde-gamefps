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
        //transform.Translate (Camera.main.transform.forward*getAnalog().y*speed*Time.deltaTime);
        transform.Translate(getKeyboard());
        //transform.Rotate (0,getAnalog().x*60*Time.deltaTime, 0);
    }

    Vector3 getKeyboard() {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Debug.Log("z: "+z);
        return new Vector3(x,0,z);
    }
}
