using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public GameObject peluru;
    public GameObject titikMuncul;
    public float powerLontar;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Tekan Space untuk melontarkan Ball
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Memunculkan Bola/Peluru dengan posisi dan rotasi yang sama dengan gameobject titikMuncul
            GameObject _ball = GameObject.Instantiate(peluru, titikMuncul.transform.position, titikMuncul.transform.rotation);
            // Melontarkan bola/peluru dengan arah dan kekuatan yang telah ditentukan
            _ball.GetComponent<Rigidbody>().AddForce(_ball.transform.forward * powerLontar);
            // menghilangkan bola/peluru setelah 2 detik
            GameObject.Destroy(_ball, 2);
        }
    }
}
