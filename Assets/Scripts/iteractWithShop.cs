using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iteractWithShop : MonoBehaviour
{
    public GameObject description;
    public GameObject cost;
    private int countObject = 2;
    private GameObject[,] shopProducts;
    private void Start()
    {
        shopProducts = new GameObject[countObject, 2];
        for (int i = 0; i < countObject; i++)
        {
            shopProducts[i, 0] = Instantiate(description, transform, false);
            shopProducts[i, 1] = Instantiate(cost, transform, false);
        }
    }
}
