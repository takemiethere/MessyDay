using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public GameObject[] UiElements;
    public bool IsActive;
  /*  public FirstPersonLook firstPersonLook;*/


    public void ActiveElement(int indexElement)
    {
        IsActive = !IsActive;
        UiElements[indexElement].SetActive(IsActive);
        
        /*foreach (var item in UiElements)
        {
            if (item != UiElements[indexElement]) // check if item is not the same as UiElement[indexElement]`
                item.SetActive(false); // deactivate item
        }*/
    }

   /* public void ResumeGame()
    {
        if (Time.timeScale == 0)//????????
        {
            *//*pauseUI.SetActive(false);*//*
            ActiveElement(1);
            Time.timeScale = 1;
            firstPersonLook.IsPlaying = true;
            Cursor.visible = IsActive;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (Time.timeScale > 0)//????????
        {
            *//*pauseUI.SetActive(true);*//*
            ActiveElement(1);
            Time.timeScale = 0;
            firstPersonLook.IsPlaying = false;
            Cursor.visible = IsActive;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }*/

    public void GotoScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void QuitGame()
    {
        Debug.Log("Close Game.exe");
        Application.Quit(); // ?????????????????????? .exe
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        // Lock the mouse cursor to the game screen.
      /*  Cursor.lockState = CursorLockMode.Locked;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)==true)
        {
            ActiveElement(1);
        }
    }
}
