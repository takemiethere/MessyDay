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

    int totalTasks;
    int completedTasks;
    private int star = 5;
    private int fromfive = 0;
    private int getfive = 0;

    private bool timerUp = false;
    private TimerAndScore timerScript;

    void Start()
    {
        trashScript = FindObjectOfType<DestroyChild>();
        dustScript = FindObjectOfType<Item>();
        bugScript = FindObjectOfType<BugDestroyUI>();
        ratScript = FindObjectOfType<RatDestroyUI>();
        timerScript = FindObjectOfType<TimerAndScore>();
    }

    private void Update()
    {
        if (timerScript.timeUp && !timerUp)
        {
            timerUp = true;
            totalTasks = trashScript.totalBin + dustScript.totalDust + bugScript.totalBug + ratScript.totalRat;

            percentageText.text = "Star: " + fromfive + "%";
        }

        if (percentageText.enabled)
        {
            completedTasks = trashScript.doneBin + dustScript.doneDust + bugScript.doneBug + ratScript.doneRat;
            fromfive = completedTasks * 100 / totalTasks;

            progressBar.fillAmount = (float)fromfive / 100;
        }
    }
}*/

using System.Collections;
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
    public int fromfive = 0;
    private int getfive = 0;

    public int totalTasks =0;
    public int completedTasks =0;

    void Start()
    {
        trashScript = FindObjectOfType<DestroyChild>();
        dustScript = FindObjectOfType<Item>();
        bugScript = FindObjectOfType<BugDestroyUI>();
        ratScript = FindObjectOfType<RatDestroyUI>();
    }

    private void Update()
    {
        totalTasks = trashScript.totalBin + dustScript.totalDust + bugScript.totalBug + ratScript.totalRat;
        completedTasks = trashScript.doneBin + dustScript.doneDust + bugScript.doneBug + ratScript.doneRat;
        fromfive = completedTasks * 100 / totalTasks;

        progressBar.fillAmount = (float)fromfive / 100;
        percentageText.text = "Star: " + fromfive + "%";
    }
}
