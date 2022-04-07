using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saves : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Script script1 = new Script();
        script1.score = (ulong)PlayerPrefs.GetInt("Score");
        Debug.Log("Data loaded");
    }

    // Update is called once per frame
   public void saveData()
    {
        Script script1 = new Script();
        PlayerPrefs.SetString("Score", script1.score.ToString());
    }
}
