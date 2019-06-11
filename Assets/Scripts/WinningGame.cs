using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningGame : MonoBehaviour {

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player") { 
            Debug.Log ("Memenangkan Permainan");
            SceneManager.LoadScene("Finish");
        }
    }
}