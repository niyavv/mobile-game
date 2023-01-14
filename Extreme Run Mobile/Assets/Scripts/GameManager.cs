using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public int score;
   
    public TMP_Text ScoreText;

    private void Start()
    {
        score = 0;//score deðeri 0 olsun 
        ScoreText.text = score.ToString();
    }

    public void UpdateScore()//updatescore fonksiyonu
    {
        score++;//score'u bir arttýr
        ScoreText.text = score.ToString();//int tanýmlanan score u string ifadeye dönüþtür
    }
}
