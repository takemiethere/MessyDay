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
    private DestroyChild BinScript;
    private Item dustScript;
    private BugDestroyUI bugScript;
    private RatDestroyUI ratScript;
    private Cleaning trashScript;

    public Image progressBar;
    public TextMeshProUGUI percentageText;

    private float star = 100;
    public float fromfive = 0;
    private float getfive = 0;
    //private float playerBonus = 15.38;
    private float playerGet = 0;

    public int totalTasks =0;
    public int completedTasks =0;

    void Start()
    {

        trashScript = FindObjectOfType<Cleaning>();
        BinScript = FindObjectOfType<DestroyChild>();
        dustScript = FindObjectOfType<Item>();
        bugScript = FindObjectOfType<BugDestroyUI>();
        ratScript = FindObjectOfType<RatDestroyUI>();


    }

    private void Update()
    {


        totalTasks = BinScript.totalBin + dustScript.totalDust + bugScript.totalBug + ratScript.totalRat; //=16
        getfive = totalTasks / totalTasks * star; //16/16*100

        completedTasks = BinScript.doneBin + dustScript.doneDust + bugScript.doneBug + ratScript.doneRat; //=2
        fromfive = completedTasks * getfive / totalTasks;
        playerGet = fromfive + 15.38f;

        progressBar.fillAmount = (float) playerGet / getfive;
        percentageText.text = "Star: " + playerGet + "%";

    }

/*    private void TimerUp()
    {




    }*/



}
