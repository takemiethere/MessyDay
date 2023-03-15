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
    //public Success scoreManager;

    public int totalRat;
    public int doneRat;

    private void Start()
    {
        UpdateUI();
    }

    private void Update()
    {

        totalRat = maxratsToDestroy;
        doneRat = ratsDestroyed;

        /*if (ratsDestroyed == maxratsToDestroy)
        {
            scoreManager.AddScore(5);
        }*/
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