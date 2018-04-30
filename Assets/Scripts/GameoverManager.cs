using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverManager : MonoBehaviour
{
    //digunakan untuk menghandle text score dan highscore
    public Text txHighscore;
    public Text txScore;

    // Use this for initialization
    void Start()
    {
        // mengambil nilai yang tersimpan dengan nilai default 0
        int highscore = PlayerPrefs.GetInt("Highscore", 0);

        // menbandingkan nilai highscore dan score. 
        //jika nilai score tersebut adalah tertinggi maka nilai score tersebut menjadi nilai highscore. 
        if (Data.score > highscore)
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("Highscore", highscore);
            PlayerPrefs.Save();
        }

        // menampilkan nilai score dan highscore
        txScore.text = Data.score.ToString();
        txHighscore.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
