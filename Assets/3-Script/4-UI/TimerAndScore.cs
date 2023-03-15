using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerAndScore : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public TextMeshProUGUI timerText;
    private bool timeUp = false;
    public Image timerBarImage;

    //public Success starManagerScript;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeLeft / 60.0f);
        int seconds = Mathf.FloorToInt(timeLeft % 60.0f);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        timerBarImage.fillAmount = timeLeft / 180.0f; // Set the fill amount based on the remaining time

        if (timeLeft < 0)
        {
            timeUp = true;
            TimeUp();
        }

    }


    void TimeUp()
    {
        Time.timeScale = 0;
        timerText.text = "Time's up!";
        // disable player's input script
        this.enabled = false;
    }

}