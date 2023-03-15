using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RatDestroyUI : MonoBehaviour
{
    public int maxratsToDestroy = 3;
    public TextMeshProUGUI text;

    private int ratsDestroyed = 0;

    private void Start()
    {
        UpdateUI();
    }

    public void RatDestroyed()
    {
        ratsDestroyed++;
        UpdateUI();

        if (ratsDestroyed >= maxratsToDestroy)
        {
            FindObjectOfType<SuccessScene>().TaskCompleted(3, 3); // task index 3 corresponds to killing rats
        }
    }

    private void UpdateUI()
    {
        text.text = "Kill " + ratsDestroyed + " / " + maxratsToDestroy + " Rats.";
    }
}