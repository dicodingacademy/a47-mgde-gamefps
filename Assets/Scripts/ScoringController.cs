using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data {
    public static int score { get; set; }
     }

public class ScoringController : MonoBehaviour
{

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
