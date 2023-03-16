/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Success : MonoBehaviour
{
    private DestroyChild trashScript;
    private Item dustScript;
    private BugDestroyUI bugScript;
    private RatDestroyUI ratScript;

    public Image progressBar;
    public TextMeshProUGUI percentageText;

    private int star = 5;
    private int fromfive = 0;
    private int getfive = 0;

    void Start()
    {
        trashScript = FindObjectOfType<DestroyChild>();
        dustScript = FindObjectOfType<Item>();
        bugScript = FindObjectOfType<BugDestroyUI>();
        ratScript = FindObjectOfType<RatDestroyUI>();
    }

    private void Update()
    {
        int totalTasks = trashScript.totalBin + dustScript.totalDust + bugScript.totalBug + ratScript.totalRat;
        int completedTasks = trashScript.doneBin + dustScript.doneDust + bugScript.doneBug + ratScript.doneRat;
        fromfive = completedTasks * 100 / totalTasks;

        progressBar.fillAmount = (float)fromfive / 100;
        percentageText.text = "Star: " + fromfive + "%";
    }
}*/