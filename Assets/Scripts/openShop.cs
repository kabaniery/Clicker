using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openShop : MonoBehaviour
{
    public Canvas shop;

    public void openS()
    {
        shop.gameObject.SetActive(true);
    }
    void Start()
    {
        shop.gameObject.SetActive(false);
    }

    public void closeShop()
    {
        shop.gameObject.SetActive(false);
    }
}
