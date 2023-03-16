/*using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerAndScore : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public TextMeshProUGUI timerText;
    public bool timeUp = false;
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

}*/


using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerAndScore : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public TextMeshProUGUI timerText;
    /*public int score = 0;
    public TextMeshProUGUI scoreText;*/
    public bool timeUp = false;
    public Image timerBarImageleft;
    public Image timerBarImageRight;

    private Success starManagerScript;

    public GameObject StarUI;
    public GameObject BDStarUI;
    public GameObject BGStarUI;
    public GameObject TextStarUI;


    void Start()
    {
        starManagerScript = FindObjectOfType<Success>();
        StarUI.SetActive(false);
        BDStarUI.SetActive(false);
        BGStarUI.SetActive(false);
        TextStarUI.SetActive(false);
    }


    void Update()
    {
        timeLeft -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeLeft / 60.0f);
        int seconds = Mathf.FloorToInt(timeLeft % 60.0f);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        timerBarImageleft.fillAmount = timeLeft / 180.0f; // Set the fill amount based on the remaining time
        timerBarImageRight.fillAmount = timeLeft / 180.0f;


        if (timeLeft < 0)
        {
            timeUp = true;
            TimeUp();
            starManagerScript.enabled = true;
        }


        if (!timeUp)
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.CompareTag("Enemy"))
                    {
                        Destroy(hit.transform.gameObject);
                        /*                        score++;
                                                scoreText.text = score + " frogs was ate.";

                                                Debug.Log("You ate: " + score + "Frogs");*/
                    }
                }
            }
        }
    }


    void TimeUp()
    {
        Time.timeScale = 0;
        timerText.text = "Time's up!";
        StarUI.SetActive(true);
        BDStarUI.SetActive(true);
        BGStarUI.SetActive(true);
        TextStarUI.SetActive(true);
        // disable player's input script
        this.enabled = false;
    }

}