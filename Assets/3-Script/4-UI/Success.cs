
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

    private TimerAndScore timerScript;

    void Start()
    {

        trashScript = FindObjectOfType<Cleaning>();
        BinScript = FindObjectOfType<DestroyChild>();
        dustScript = FindObjectOfType<Item>();
        bugScript = FindObjectOfType<BugDestroyUI>();
        ratScript = FindObjectOfType<RatDestroyUI>();

        timerScript = FindObjectOfType<TimerAndScore>();
    }

    private void Update()
    {


        /* totalTasks = BinScript.totalBin + dustScript.totalDust + bugScript.totalBug + ratScript.totalRat; //=16
         getfive = totalTasks / totalTasks * star; //16/16*100

         completedTasks = BinScript.doneBin + dustScript.doneDust + bugScript.doneBug + ratScript.doneRat; //=2
         fromfive = completedTasks * getfive / totalTasks;
         playerGet = fromfive + 15.38f;

         progressBar.fillAmount = (float) playerGet / getfive;
         percentageText.text = "Star: " + playerGet + "%";*/



        if (timerScript.timeUp)
        {
            totalTasks = BinScript.totalBin + dustScript.totalDust + bugScript.totalBug + ratScript.totalRat;
            getfive = totalTasks / totalTasks * star;

            completedTasks = BinScript.doneBin + dustScript.doneDust + bugScript.doneBug + ratScript.doneRat;
            fromfive = completedTasks * getfive / totalTasks;
            playerGet = fromfive + 15.38f;

            progressBar.fillAmount = (float)playerGet / getfive;
            percentageText.text = "Star: " + playerGet + "%";
        }
    }

/*    private void TimerUp()
    {




    }*/



}
