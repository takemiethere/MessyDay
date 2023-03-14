using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessScene : MonoBehaviour
{
    public int numTasks = 4;
    public int maxScore = 5;
    public int[] taskMaxScores = { 5, 5, 3, 3 }; // max score for each task in the order they were listed

    private int[] taskScores = { 0, 0, 0, 0 }; // current score for each task in the order they were listed
    private int totalScore = 0;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void TaskCompleted(int taskIndex, int score)
    {
        taskScores[taskIndex] = score;
        totalScore = 0;
        for (int i = 0; i < numTasks; i++)
        {
            totalScore += taskScores[i];
        }
        totalScore = Mathf.Clamp(totalScore, 0, maxScore * numTasks);
    }

    public void ShowSuccessScene()
    {
        SceneManager.LoadScene("SuccessScene");
    }

    public int GetScore()
    {
        return totalScore;
    }

    public int GetMaxScore()
    {
        return maxScore * numTasks;
    }

    public int GetTaskMaxScore(int taskIndex)
    {
        return taskMaxScores[taskIndex];
    }

    public int GetTaskScore(int taskIndex)
    {
        return taskScores[taskIndex];
    }
}
