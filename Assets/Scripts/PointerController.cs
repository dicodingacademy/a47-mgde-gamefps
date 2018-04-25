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
            Debug.Log("name: "+hit.transform.tag);
            if (hit.collider)
            {
               // transform.position = hit.point;
                if (hit.transform.tag.Equals("UI"))
                {
                    Debug.Log("Hit UI");
                    hit.transform.GetComponent<RespondCode>().SetHit();
                    if (Input.GetMouseButtonUp(0) || OVRInput.GetUp(OVRInput.Touch.PrimaryTouchpad))
                    {
                        hit.transform.GetComponent<RespondCode>().SetClick();
                    }
                }
            }
        }
        else
        {
           // transform.position = transform.forward*10;
        }
    }
}