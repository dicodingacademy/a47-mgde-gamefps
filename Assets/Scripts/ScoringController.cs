using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Oculus.Platform;

public class Data {
    public static int score { get; set; }
     }

public class ScoringController : MonoBehaviour
{

    //public void Awake()
    //{
    //    try
    //    {
    //        Core.AsyncInitialize("1600470856717855");
    //        Entitlements.IsUserEntitledToApplication().OnComplete(GetEntitlementCallback);
    //    }
    //    catch (UnityException e)
    //    {
    //        Debug.LogError("Platform failed to initialize due to exception.");
    //        Debug.LogException(e);
    //        // Immediately quit the application.
    //        UnityEngine.Application.Quit();
    //    }
    //}

    //void GetEntitlementCallback(Message msg)
    //{
    //    if (msg.IsError)
    //    {
    //        Debug.LogError("You are NOT entitled to use this app.");
    //        UnityEngine.Application.Quit();
    //    }
    //    else
    //    {
    //        Debug.Log("You are entitled to use this app.");
    //    }
    //}

    public Text coinLabel;

    private static ScoringController instance;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addCoin()
    {
        Data.score++;
        coinLabel.text = "Coin: " + Data.score.ToString();
    }

    public static ScoringController GetInstance()
    {
        return instance;
    }
}
