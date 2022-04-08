using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Script : MonoBehaviour
{
    public ulong score = 0;
    public Text scoreText;
    private string[] uom = { "", "k", "m", "M", "T", "q", "Q" };

    public void isClicked()
    {
        score++;
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
        scoreText.text = Math.Round(res, 3).ToString() + uom[stepen];
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }
}
