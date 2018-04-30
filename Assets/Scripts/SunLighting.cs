using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLighting : MonoBehaviour
{

    public float speedRotationSun;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //mencari nilai sudut yang akan ditambahkan
        float angle = Time.deltaTime * speedRotationSun;
        // implementasi nilai untuk rotasi matahari
        transform.RotateAround(transform.position, Vector3.forward, angle);
    }
}