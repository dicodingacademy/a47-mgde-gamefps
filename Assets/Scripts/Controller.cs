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
        transform.Translate(getController());
    }

    // digunakan untuk mendapatkan input gerak dari keyboard
    Vector3 getKeyboard()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Debug.Log("z: " + z);
        return new Vector3(x, 0, z);
    }

    // digunakan untuk mendapatkan input gerak dari Controller
    Vector3 getController()
    {
        float x = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).x * speed * Time.deltaTime;
        float z = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).y * speed * Time.deltaTime;
        return new Vector3(x, 0, z);
    }
}
