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




    void Start()
    {
        uiText.text = "Clear the dust 0/" + maxToDestroy.ToString();
        toolSwitcher = FindObjectOfType<ToolSwitcher>();
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
