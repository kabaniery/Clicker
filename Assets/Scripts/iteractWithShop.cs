using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class iteractWithShop : MonoBehaviour
{
    public GameObject description;
    public GameObject cost;
    public int countObject = 4;
    private GameObject[,] shopProducts;
    private Vector2[] productsCoords;
    private int countClicks;
    private bool isActive = true;
    private void Start()
    {

        shopProducts = new GameObject[countObject, 2];
        productsCoords = new Vector2[countObject];
        for (int i = 0; i < countObject; i++)
        {
            shopProducts[i, 0] = Instantiate(description, transform, false);
            shopProducts[i, 1] = Instantiate(cost, transform, false);
            if (i == 0)
            {
                productsCoords[i] = new Vector2((shopProducts[i, 0].transform.localPosition.x + shopProducts[i, 1].transform.localPosition.x) / 2, shopProducts[i, 0].transform.localPosition.y);
            }
            else
            {
                shopProducts[i, 0].transform.localPosition = new Vector2(shopProducts[i - 1, 0].transform.localPosition.x, shopProducts[i - 1, 0].transform.localPosition.y - 250);
                shopProducts[i, 1].transform.localPosition = new Vector2(shopProducts[i - 1, 1].transform.localPosition.x, shopProducts[i - 1, 1].transform.localPosition.y - 250);
                productsCoords[i] = new Vector2((shopProducts[i, 0].transform.localPosition.x + shopProducts[i, 1].transform.localPosition.x) / 2, shopProducts[i, 0].transform.localPosition.y);
                //Тута же будем вписывать цену элементов и т.д. Но так как я в душе не ебу, что за названия, действия и цены у товаров, оставлю их просто разноцветными прямоугольниками
            }
        }
    }
    void Update()
    {
        if (isActive)
        {
            if (Input.GetMouseButtonDown(0)) //Поменять, сука, на мобильную альтернативу!!!!!!!!!!!!!!!!!!!!!!!!!!! ИНАЧЕ БАН
            {
                Debug.Log(Input.mousePosition.x.ToString() + " " + Input.mousePosition.y.ToString());
                for (int i = 0; i < countObject; i++)
                {
                    if (Math.Abs(productsCoords[i].x - Input.mousePosition.x) <= 340 && Math.Abs(productsCoords[i].y - Input.mousePosition.y) <= 150)
                    {
                        mouseClicked(i);
                    }
                }
            }
        }
    }
    public void shopClosed()
    {
        isActive = false;
    }
    public void shopOpen()
    {
        isActive = true;
    }
    void mouseClicked(int id)
    {
        Debug.Log(id);
    }
}
