using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            // mengecek object yang dideteksi harus memiliki collider
            if (hit.collider)
            {
                // pastikan object yang dideteksi memiliki tag UI
                if (hit.transform.tag.Equals("UI"))
                {
                    hit.transform.GetComponent<RespondButton>().SetHit();

                    // ketika user menekan/klik tombol
                    if (Input.GetMouseButtonUp(0))
                    {
                        hit.transform.GetComponent<RespondButton>().SetClick();
                    }
                }
            }
        }

    }
}
