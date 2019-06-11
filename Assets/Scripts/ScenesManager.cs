using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

    public void MenuScene() {
        SceneManager.LoadScene("Menu");
        Debug.Log("Ke Menu");
    }

    public void MainScene() {
        SceneManager.LoadScene("Main");
        Debug.Log("Mulai Permainan");
    }

    public void QuitScene() {
        Application.Quit();
        Debug.Log("Keluar");
    }
}