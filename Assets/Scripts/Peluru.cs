using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        //Jika peluru menyentuh benda yang memiliki collider maka object tersebut akan terdestroy
        Destroy(gameObject);
    }
}
