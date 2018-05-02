using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControl : MonoBehaviour
{

    private LineRenderer laser;

    // Use this for initialization
    void Start()
    {
        laser = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // posisi laser yang dekat dengan camera
        laser.SetPosition(0, transform.position);

        // mengecek object yang terdapat didepan camera
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            // mengecek object yang dideteksi harus memiliki collider
            if (hit.collider)
            {
                //jarak ujung laser berdasarkan posisi laser terkena object
                laser.SetPosition(1, hit.point);
              
                // pastikan object yang dideteksi memiliki tag UI
                if (hit.transform.tag.Equals("UI"))
                {
                    hit.transform.GetComponent<RespondButton>().SetHit();
                    
                    // ketika user menekan/klik tombol
                    if (OVRInput.GetDown(OVRInput.RawButton.A))
                    {
                        hit.transform.GetComponent<RespondButton>().SetClick();
                    }
                }
            }
        }
        else
        {
            // memberi batasan jarak laser terjauh dengan nilai maksimal 5000
            laser.SetPosition(1, transform.forward * 5000);
        }
    }
}
