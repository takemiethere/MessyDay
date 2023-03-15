using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{

    public int maxClicks = 5;
    public static int numDestroyed = 0;
    public static int maxToDestroy = 5;
    public TextMeshProUGUI uiText;

    private int currentClicks = 0;

    private ToolSwitcher toolSwitcher;


    public int totalDust;
    public int doneDust;
    
    //public Success scoreManager;
    void Start()
    {
        uiText.text = "Clear the dust 0/" + maxToDestroy.ToString();
        toolSwitcher = FindObjectOfType<ToolSwitcher>();
    }

    private void Update()
    {


        totalDust = maxToDestroy;
        doneDust = numDestroyed;



    /*if (numDestroyed == maxToDestroy)
        {
            scoreManager.AddScore(5);
        }*/
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
            
            if (numDestroyed >= maxToDestroy)  //big O
            {
                FindObjectOfType<SuccessScene>().TaskCompleted(1, 5); // task index 1 corresponds to wiping dust
            }

        }


        uiText.text = "Wiped " + numDestroyed.ToString() + "/" + maxToDestroy.ToString();

        if (numDestroyed == maxToDestroy)
        {

        }

        if (toolSwitcher.GetActiveToolIndex() == 0) // Check if the active tool is the first tool
        {
            // Perform the action for taking the trash to the bin
        }
    }
}