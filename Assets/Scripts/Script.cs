using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Script : MonoBehaviour
{
    public ulong score = 0;
    private string result;
    public Text scoreText;
    private string[] uom = { "", "k", "m", "M", "T", "q", "Q" };
    public ulong ShopBonusClick;

    public void isClicked()
    {
        GetScoreClick(); 
        int stepen = 0;
        for (ulong i = score; i > 0; i /= 1000)
        {
            stepen++;
        }
        stepen--;
        double res = (double)score;
        if (stepen != 0)
        {
            res = res / Math.Pow(1000, stepen);
        }
        result = Math.Round(res, 3).ToString();
        scoreText.text = result + uom[stepen];
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetScoreClick()
    {
        score = score + 1 + ShopBonusClick;
    }
}
