using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespondButton : MonoBehaviour
{

    public Image imgButton;
    public string nameScene;
    public Color Normal = Color.yellow;
    public Color Click = Color.red;
    private bool isHit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // digunakan untuk mengganti warna pada Background di tombol 
    private void FixedUpdate()
    {
        if (isHit)
        {
            imgButton.color = Color.green;
            isHit = false;
            return;
        }
        else
        {
            imgButton.color = Normal;
        }
    }

    // ketika pointer atau laser diatas tombol
    public void SetHit()
    {
        isHit = true;
    }

    // ketika klik tombol
    public void SetClick()
    {
        imgButton.color = Click;
        SceneManager.LoadScene(nameScene);
    }
}
