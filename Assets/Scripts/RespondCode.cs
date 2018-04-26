using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespondCode : MonoBehaviour {

    public Image btnPlay;
    public string nameScene;
    public Color Normal = Color.yellow;
    public Color Click = Color.red;
    private bool isHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void FixedUpdate()
    {
        if (isHit)
        {
            btnPlay.color = Color.green;
            isHit = false;
            return;
        }
        else {
            btnPlay.color = Normal;
        }
    }

    public void SetHit() {
        isHit = true;
    }

    public void SetClick() {
        btnPlay.color = Click;
        SceneManager.LoadScene(nameScene);
    }
}
