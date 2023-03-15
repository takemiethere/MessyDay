using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    [SerializeField]
    public GameObject[] UiElements;
    public GameObject[] UiBT;
    public FirstPersonLook firstPersonLook;

    public void ActiveElement(int indexElement)
    {
        bool isActive = !UiElements[indexElement].activeSelf;
        UiElements[indexElement].SetActive(isActive);

        /*foreach (var item in UiElements)
        {
            if (item != UiElements[indexElement])
                item.SetActive(false);
        }*/
    }

    public void ActiveBT(int indexBT)
    {
        bool isActive = !UiBT[indexBT].activeSelf;
        UiBT[indexBT].SetActive(isActive);

        foreach (var item in UiBT)
        {
            if (item != UiBT[indexBT])
                item.SetActive(false);
        }
    }

    public void ResumeGame()
    {
        if (Time.timeScale == 0)
        {
            ActiveElement(0);
            Time.timeScale = 1;
            firstPersonLook.IsPlaying = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (Time.timeScale > 0)
        {
            ActiveElement(0);
            Time.timeScale = 0;
            firstPersonLook.IsPlaying = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    public void GotoScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
        ActiveElement(1);
    }

    public void QuitGame()
    {
        Debug.Log("Close Game.exe");
        Application.Quit();
    }

    void Start()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResumeGame();
        }
    }
}
