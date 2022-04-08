using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saves : MonoBehaviour
{
    public ulong scoreToSave;

    public void printScore()
    {
        scoreToSave = gameObject.GetComponent<Script>().score;
        Debug.Log(scoreToSave.ToString());
    }
    void OnApplicationQuit()
    {
        scoreToSave = gameObject.GetComponent<Script>().score;
        Debug.Log(scoreToSave.ToString());
        PlayerPrefs.SetString("SavedString", scoreToSave.ToString());
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }
    void Start()
    {
        gameObject.GetComponent<Script>().score = ulong.Parse(PlayerPrefs.GetString("SavedString"));
    }
}
