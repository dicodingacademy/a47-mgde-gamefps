using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverManager : MonoBehaviour
{
    public Text txHighscore;
    public Text txScore;

    // Use this for initialization
    void Start()
    {
        int highscore = PlayerPrefs.GetInt("Highscore", 0);
        if (Data.score > highscore)
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("Highscore", highscore);
            PlayerPrefs.Save();
        }

        txScore.text = Data.score.ToString();
        txHighscore.text = highscore.ToString();

        Data.score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
