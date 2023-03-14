using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{

    public int maxClicks = 5;
    public static int numDestroyed = 0;
    public static int numToDestroy = 5;
    public TextMeshProUGUI uiText;

    private int currentClicks = 0;

    void Start()
    {
        uiText.text = "Clear the dust 0/" + numToDestroy.ToString();
    }

    void OnMouseDown()
    {
        if (currentClicks < maxClicks)
        {
            currentClicks++;

            /*Color fadedColor = material.color;   
            fadedColor.a -= fadeAmount;          
            material.color = fadedColor;  */       


        }
        else
        {
            //Destroy(gameObject);
            Destroy(gameObject);
            numDestroyed++;

        }
        

        uiText.text = "Wiped " + numDestroyed.ToString() + "/" + numToDestroy.ToString();

        if (numDestroyed == numToDestroy)
        {
            
        }
    }
}
