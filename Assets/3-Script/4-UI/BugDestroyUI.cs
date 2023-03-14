using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BugDestroyUI : MonoBehaviour
{
    public int maxbugsToDestroy = 3;
    public TextMeshProUGUI textbug;

    private int bugsDestroyed = 0;

    private void Start()
    {
        UpdateUI();
    }

    public void BugDestroyed()
    {
        bugsDestroyed++;
        UpdateUI();

        if (bugsDestroyed >= maxbugsToDestroy)
        {
            FindObjectOfType<SuccessScene>().TaskCompleted(2, 3); // task index 2 corresponds to killing bugs
        }
    }

    private void UpdateUI()
    {
        textbug.text = "Kill " + bugsDestroyed + " / " + maxbugsToDestroy + " Cockroacs";
    }
}