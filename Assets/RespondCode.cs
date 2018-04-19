using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespondCode : MonoBehaviour {

    public Image btnPlay;
    public string nameScene;
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
            btnPlay.color = Color.white;
        }
    }

    public void SetHit() {
        isHit = true;
    }

    public void SetClick() {
        btnPlay.color = Color.red;
        SceneManager.LoadScene(nameScene);
    }
}
