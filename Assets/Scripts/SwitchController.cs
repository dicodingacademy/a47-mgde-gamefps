using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{

    public GameObject controllerDefault;
    bool isShow;

    // Use this for initialization
    void Start()
    {
        isShow = false;
        controllerDefault.SetActive(false);
    }

    public bool ControllerIsConnected
    {
        get
        {
            OVRInput.Controller controller = OVRInput.GetConnectedControllers() & (OVRInput.Controller.LTrackedRemote | OVRInput.Controller.RTrackedRemote);
            return controller == OVRInput.Controller.LTrackedRemote || controller == OVRInput.Controller.RTrackedRemote;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ControllerIsConnected)
        {
            if (isShow)
            {
                controllerDefault.SetActive(false);
                isShow = false;
            }
        }
        else
        {
            if (!isShow)
            {
                controllerDefault.SetActive(true);
                isShow = true;
            }
        }

        Debug.Log("ControllerIsConnected:" + ControllerIsConnected + ", isShow:" + isShow);
    }
}
