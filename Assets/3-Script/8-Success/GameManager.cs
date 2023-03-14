using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int numTasks = 4;
    public int[] maxStarsPerTask = { 5, 3, 5, 10 };
    public SuccessScene successScene;

    private int[] tasksCompleted = new int[4];

    // other code here

    public void TaskCompleted(int taskId)
    {
        tasksCompleted[taskId]++;
        if (AllTasksCompleted())
        {
            int starsEarned = CalculateStars();
            successScene.TaskCompleted(taskId, starsEarned);
            successScene.ShowSuccessScene();
        }
    }

    private bool AllTasksCompleted()
    {
        for (int i = 0; i < numTasks; i++)
        {
            if (tasksCompleted[i] == 0)
            {
                return false;
            }
        }
        return true;
    }

    private int CalculateStars()
    {
        int totalStarsEarned = 0;
        for (int i = 0; i < numTasks; i++)
        {
            float taskCompletionRatio = (float)tasksCompleted[i] / maxStarsPerTask[i];
            int starsEarned = Mathf.RoundToInt(taskCompletionRatio * 5);
            totalStarsEarned += starsEarned;
        }
        int averageStars = Mathf.RoundToInt((float)totalStarsEarned / numTasks);
        return averageStars;
    }

    // other code here
}
