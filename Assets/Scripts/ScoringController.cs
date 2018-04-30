using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data {
    //Penggunaan static supaya nilai score ini dapat diakses oleh scene lain
    public static int score { get; set; }
     }

public class ScoringController : MonoBehaviour
{
    // digunakan untuk menghandle coinLabel
    public Text coinLabel;

    // digunakan untuk menyimpan class yang nanti akan dipanggil di class lain
    private static ScoringController instance;

    // Use this for initialization
    void Start()
    {
        //digunakan untuk inisialisasi variable instance
        instance = this;
        // setiap dimulai, pastikan score bernilai 0
        Data.score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore()
    {
        //menambahkan nilai 1 setiap kali dijalakan
        Data.score++;
        // menampilkan jimlah score ke UI Text Score
        coinLabel.text = "Coin: " + Data.score.ToString();
    }

    public void ResetScore()
    {
        Data.score = 0;
    }

    //digunakan untuk mempermudah pemanggilan di class lain
    public static ScoringController GetInstance()
    {
        return instance;
    }
}
