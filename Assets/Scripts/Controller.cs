using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    // digunakan untuk mengatur kecepatan gerakkan player
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // implementasikan pergerakkan Player dari Inputan yang diberikan
        transform.Translate(getKeyboard());
    }

    // digunakan untuk mendapatkan input gerak dari keyboard
    Vector3 getKeyboard()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Debug.Log("z: " + z);
        return new Vector3(x, 0, z);
    }
}
